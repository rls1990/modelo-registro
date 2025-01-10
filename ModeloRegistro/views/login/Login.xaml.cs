using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace ModeloRegistro.views.login
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login:Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void username_TextChanged( object sender,TextChangedEventArgs e )
        {
            ValidateUserName();
        }

        private void user_password_PasswordChanged( object sender,RoutedEventArgs e )
        {
            ValidateUserPassword();
        }

        private void username_KeyDown( object sender,System.Windows.Input.KeyEventArgs e )
        {
            if(e.Key==Key.Enter)
            {
                VerifyCredentials();
            }
        }

        private void user_password_KeyDown( object sender,System.Windows.Input.KeyEventArgs e )
        {
            if(e.Key==Key.Enter)
                VerifyCredentials();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            VerifyCredentials();
        }

        private bool ValidateUserName()
        {
            if(!Regex.IsMatch(username.Text,@"^[a-zA-Z0-9]+$"))
            {
                if(username.Text.Length==0)
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(username,"El username es requerido");
                else
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(username,"Solo se aceptan letras y números");
                MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(username,Brushes.Red);
                MaterialDesignThemes.Wpf.HintAssist.SetForeground(username,Brushes.Red);

                Style helperTextStyle = new Style(typeof(TextBlock))
                {
                    BasedOn=(Style)FindResource("MaterialDesignHelperTextBlock")
                };
                helperTextStyle.Setters.Add(new Setter(TextBlock.ForegroundProperty,Brushes.Red));
                MaterialDesignThemes.Wpf.HintAssist.SetHelperTextStyle(username,helperTextStyle);
                icon_username.Foreground=Brushes.Red;

                return false;
            } else
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(username,"ok");
                MaterialDesignThemes.Wpf.ValidationAssist.SetHasError(username,false);
                MaterialDesignThemes.Wpf.HintAssist.SetForeground(username,Brushes.Green);
                MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(username,Brushes.Green);
                icon_username.Foreground=Brushes.Green;

                Style helperTextStyle = new Style(typeof(TextBlock))
                {
                    BasedOn=(Style)FindResource("MaterialDesignHelperTextBlock")
                };
                helperTextStyle.Setters.Add(new Setter(TextBlock.ForegroundProperty,Brushes.Green));
                MaterialDesignThemes.Wpf.HintAssist.SetHelperTextStyle(username,helperTextStyle);

                return true;
            }
           
        }

        private bool ValidateUserPassword()
        {
            if(!Regex.IsMatch(user_password.Password,@"^[a-zA-Z0-9]+$"))
            {
                if(user_password.Password.Length==0)
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(user_password,"El password es requerido");
                else
                    MaterialDesignThemes.Wpf.HintAssist.SetHelperText(user_password,"Solo se aceptan letras y números");
                MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(user_password,Brushes.Red);

                Style helperTextStyle = new Style(typeof(TextBlock))
                {
                    BasedOn=(Style)FindResource("MaterialDesignHelperTextBlock")
                };
                helperTextStyle.Setters.Add(new Setter(TextBlock.ForegroundProperty,Brushes.Red));
                MaterialDesignThemes.Wpf.HintAssist.SetHelperTextStyle(user_password,helperTextStyle);
                MaterialDesignThemes.Wpf.HintAssist.SetForeground(user_password,Brushes.Red);
                icon_user_password.Foreground=Brushes.Red;

                return false;
            } else
            {
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(user_password,"ok");
                MaterialDesignThemes.Wpf.ValidationAssist.SetHasError(user_password,false);
                MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(user_password,Brushes.Green);
                MaterialDesignThemes.Wpf.HintAssist.SetForeground(user_password,Brushes.Green);

                Style helperTextStyle = new Style(typeof(TextBlock))
                {
                    BasedOn=(Style)FindResource("MaterialDesignHelperTextBlock")
                };
                helperTextStyle.Setters.Add(new Setter(TextBlock.ForegroundProperty,Brushes.Green));
                MaterialDesignThemes.Wpf.HintAssist.SetHelperTextStyle(user_password,helperTextStyle);
                icon_user_password.Foreground=Brushes.Green;

                return true;
            }
        }

        private async void VerifyCredentials()
        {

            if(ValidateUserName()&&ValidateUserPassword())
            {
                if(username.Text=="admin"&&user_password.Password=="admin")
                {
                     await services.PageService.LoadPage(new dashboard.Dashboard(),services.Global.frame,1500);
                } else
                    MessageBox.Show("Credenciales Incorrectas","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

    }


}
