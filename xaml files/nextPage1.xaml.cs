using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace quizapp
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class nextPage1 : quizapp.Common.LayoutAwarePage
    {
        public nextPage1()
        {
            this.InitializeComponent();
            Storyboard1.Begin();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        /*      private void is_Checked(object sender, RoutedEventArgs e)
              {
                  if (radioButton1.IsChecked == true)
                  {
                      answer.Text = "correct";
                  }
                  else
                  {
                      answer.Text = "wrong";
                  }
              }

              private void is_Checked1(object sender, RoutedEventArgs e)
              {
                  if (radioButton6.IsChecked == true)
                  {
                      answer1.Text = "correct";
                  }
                  else
                      answer1.Text = "wrong";
              }

              private void is_Checked2(object sender, RoutedEventArgs e)
              {
                  if (rb1.IsChecked == true)
                  {
                      answer2.Text = "correct";
                  }
                  else
                      answer2.Text = "wrong";
              }*/

        private void onclick2(object sender, RoutedEventArgs e)
        {
            if ((radioButton1.IsChecked == true) && (rb1.IsChecked == true) && (radioButton6.IsChecked == true))
            {
                mark.Text = "3 marks";
            }
            else
            {
                if ((radioButton1.IsChecked == false) && (rb1.IsChecked == true) && (radioButton6.IsChecked == true))
                {
                    mark.Text = "2 marks";
                }
                else
                {
                    if ((radioButton1.IsChecked == true) && (rb1.IsChecked == false) && (radioButton6.IsChecked == true))
                    {
                        mark.Text = "2 marks";
                    }
                    else
                    {
                        if ((radioButton1.IsChecked == true) && (rb1.IsChecked == true) && (radioButton6.IsChecked == false))
                        {
                            mark.Text = "2 marks";
                        }
                        else
                        {
                            if ((radioButton1.IsChecked == true) && (rb1.IsChecked == false) && (radioButton6.IsChecked == false))
                            {
                                mark.Text = "1 marks";
                            }
                            else
                            {
                                if ((radioButton1.IsChecked == false) && (rb1.IsChecked == true) && (radioButton6.IsChecked == false))
                                {
                                    mark.Text = "1 marks";
                                }
                                else
                                {
                                     if ((radioButton1.IsChecked == false) && (rb1.IsChecked == false) && (radioButton6.IsChecked == true))
                            {
                                mark.Text = "1 marks";
                            }
                                   
                                    else
                                    {

                                        if ((radioButton1.IsChecked == false) && (rb1.IsChecked == false) && (radioButton6.IsChecked == false))
                                        {
                                            mark.Text = "0 marks";
                                        }

                                    }
                                }
                            }
                    }
                        }
                }
            }
        }
    }
}
