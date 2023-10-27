using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using guia_curso.Models;

namespace guia_curso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e Tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em Língua portuguesa, utilizando o vocabulário técnico da área e" +
                                                    "elaborar registros e planulhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "*Incentivar o diálogo e interlocução. *Responsabilizar-se pela produção, utilização e " +
                                        "divulgação de informações.  *Estimular a proatividade.",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Algoritmos",

                    AtribuicoesResponsabilidades = "*Implementar algoritmos em linguagem de programação,utilizando ambientes de" +
                                                    "desenvolvimento de acordo com as necessidades.",

                    ValoresAtitudes = "*Estimular a organização. *Incentivar atitudes de autonomia. *Fortalecer a persistência" +
                                        "e o interresse na resolução de situações-problema.",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "Modelar banco de dados",
                                                

                    ValoresAtitudes = "*Estimular a organização. *Fortalecer a persistência e o interesse na resoluçaõ " +
                                        "de situação-problema. *Promover ações que considerem o respeito as normas estabelecidas.",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Análise e Projeto de Sistemas",

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.",
                                      

                    ValoresAtitudes = "*Estimular a organização. *Incentivar a criatividade. *Fortalecer a percistência" +
                                        "e o interesse na resolução de situações-problema.",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desing Digital",

                    AtribuicoesResponsabilidades = "Desenvolver elementos gáficos para aplicativos e sites.",
                                                

                    ValoresAtitudes = "*Incentivar a criatividade. *Respeitar as manifestações culturais de outros povos. " +
                                        "*Incentivar ações que promova a cooperação",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "Desenvolver sites para Web",
                                                 

                    ValoresAtitudes = "*incentivar a criatividade. *Estimular a organização. *Fortalecer a persistência" +
                                        "e o interesse na resolução de situação-problema",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais",
                                                  

                    ValoresAtitudes = "*Desenvolver a criatividade. *Incentivar comportamentos éticos. *Promover" +
                                        "ações que considerem o respeito as normas estabelecidas.",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Técnicas de Programação",

                    AtribuicoesResponsabilidades = "*Desenvolver programas de computador, utilizando princípios de boas práticas " +
                                                    "*Realizar versionamento no desenvolvimento de programas. *Verificar" +
                                                    "usabilidade no desenvolvimento de programas",
                    ValoresAtitudes = "*Incentivar a criatividade. *Incentivar comportamentos éticos. *Fortalecer a persistência e" +
                                        "o interesse na resolução dfe situação-problema",
                };

                await Navigation.PushAsync(new VerCoMponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}