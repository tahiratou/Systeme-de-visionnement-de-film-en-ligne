using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
	public partial class Connexion : Form
	{
		private readonly IAuthentificationService _authService;
		private readonly IServiceProvider _serviceProvider;

		public Connexion(IAuthentificationService authService, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			this.Text = "VisionFlix - Connexion";

			_authService = authService;
			_serviceProvider = serviceProvider;

			ConfigurerEvenementsClavier();
		}

		/// <summary>
		/// Configure les événements clavier pour permettre la connexion avec Entrée
		/// </summary>
		private void ConfigurerEvenementsClavier()
		{
			txtIdentifiant.KeyPress += TxtIdentifiant_KeyPress;
			txtMotDePasse.KeyPress += TxtMotDePasse_KeyPress;
		}

		/// <summary>
		/// Gère la touche Entrée sur le champ identifiant
		/// </summary>
		private void TxtIdentifiant_KeyPress(object? sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true; 
				txtMotDePasse.Focus();
			}
		}

		/// <summary>
		/// Gère la touche Entrée sur le champ mot de passe
		/// </summary>
		private void TxtMotDePasse_KeyPress(object? sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true; 

				btnLogin_Click(sender, e);
			}
		}

		private async void btnLogin_Click(object? sender, EventArgs e)
		{
			string nomUtilisateur = txtIdentifiant.Text.Trim();
			string motDePasse = txtMotDePasse.Text;

			if (string.IsNullOrWhiteSpace(nomUtilisateur))
			{
				MessageBox.Show("Veuillez entrer votre nom d'utilisateur.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtIdentifiant.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(motDePasse))
			{
				MessageBox.Show("Veuillez entrer votre mot de passe.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMotDePasse.Focus();
				return;
			}

			btnLogin.Enabled = false;
			btnLogin.Text = "Connexion en cours...";

			try
			{
				var utilisateur = await _authService.ConnecterAsync(nomUtilisateur, motDePasse);

				if (utilisateur != null)
				{
					MessageBox.Show($"Bienvenue {utilisateur.Prenom} {utilisateur.Nom}!",
						"Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

					

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
				else
				{
					MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion",
						MessageBoxButtons.OK, MessageBoxIcon.Error);

					// Mettre le focus sur le nom d'utilisateur pour permettre une nouvelle tentative
					txtIdentifiant.Focus();
					txtIdentifiant.SelectAll();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Réactiver le bouton
				btnLogin.Enabled = true;
				btnLogin.Text = "Connexion";
			}
		}

		// Lien "S'inscrire"
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var inscriptionForm = _serviceProvider.GetRequiredService<Inscription>();
			this.Hide();  // Cache la connexion

			var result = inscriptionForm.ShowDialog();

			if (result == DialogResult.OK)
			{
				// L'inscription a réussi, on peut fermer la connexion
				this.Close();
			}
			else
			{
				// L'utilisateur a annulé, on réaffiche la connexion
				this.Show();
			}
		}
	}
}

