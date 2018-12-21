﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EscolaVirtual.Cadastro.TestesAceitacao.CadastroAluno
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CadastrarUmNovoAlunoFeature : Xunit.IClassFixture<CadastrarUmNovoAlunoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CadastroAluno.feature"
#line hidden
        
        public CadastrarUmNovoAlunoFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Cadastrar um novo Aluno", "\tUm aluno fará seu cadastro pelo site\r\n\tpreenchendo os campos necessários\r\n\tao te" +
                    "rminar receberá uma notificacao \r\n\tde sucesso ou de falha", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(CadastrarUmNovoAlunoFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "CadastroAlunoSucesso")]
        [Xunit.TraitAttribute("Category", "TesteAceitacaoCadastroAluno")]
        public virtual void CadastroAlunoSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CadastroAlunoSucesso", new string[] {
                        "TesteAceitacaoCadastroAluno"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 11
 testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table1.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table1.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table1.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table1.AddRow(new string[] {
                        "Senha",
                        "Teste@123"});
            table1.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste@123"});
#line 12
 testRunner.And("preenche os campos com os valores", ((string)(null)), table1, "E ");
#line 19
 testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 20
 testRunner.Then("Recebe uma mensagem de cadastro com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com CPF já utilizado")]
        public virtual void CadastroDeAlunoComCPFJaUtilizado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com CPF já utilizado", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 24
 testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table2.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table2.AddRow(new string[] {
                        "Email",
                        "contato2@eduardopires.net.br"});
            table2.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table2.AddRow(new string[] {
                        "Senha",
                        "Teste@123"});
            table2.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste@123"});
#line 25
 testRunner.And("preenche os campos com os valores", ((string)(null)), table2, "E ");
#line 32
 testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 33
 testRunner.Then("Recebe uma mensagem de erro de CPF já cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Email já utilizado")]
        public virtual void CadastroDeAlunoComEmailJaUtilizado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Email já utilizado", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 37
 testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table3.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table3.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table3.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table3.AddRow(new string[] {
                        "Senha",
                        "Teste@123"});
            table3.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste@123"});
#line 38
 testRunner.And("preenche os campos com os valores", ((string)(null)), table3, "E ");
#line 45
 testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 46
 testRunner.Then("recebe uma mensagem de erro de email já cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha sem números")]
        public virtual void CadastroDeAlunoComSenhaSemNumeros()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha sem números", ((string[])(null)));
#line 48
 this.ScenarioSetup(scenarioInfo);
#line 49
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 50
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table4.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table4.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table4.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table4.AddRow(new string[] {
                        "Senha",
                        "Teste@"});
            table4.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste@"});
#line 51
  testRunner.And("preenche os campos com os valores", ((string)(null)), table4, "E ");
#line 58
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 59
  testRunner.Then("Recebe uma mensagem de erro de que a senha requer numero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha sem Maiuscula")]
        public virtual void CadastroDeAlunoComSenhaSemMaiuscula()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha sem Maiuscula", ((string[])(null)));
#line 61
 this.ScenarioSetup(scenarioInfo);
#line 62
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 63
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table5.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table5.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table5.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table5.AddRow(new string[] {
                        "Senha",
                        "teste@123"});
            table5.AddRow(new string[] {
                        "RepitaSenha",
                        "teste@123"});
#line 64
  testRunner.And("preenche os campos com os valores", ((string)(null)), table5, "E ");
#line 71
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 72
  testRunner.Then("Recebe uma mensagem de erro de que a senha requer letra maiuscula", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha sem minuscula")]
        public virtual void CadastroDeAlunoComSenhaSemMinuscula()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha sem minuscula", ((string[])(null)));
#line 74
 this.ScenarioSetup(scenarioInfo);
#line 75
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 76
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table6.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table6.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table6.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table6.AddRow(new string[] {
                        "Senha",
                        "TESTE@123"});
            table6.AddRow(new string[] {
                        "RepitaSenha",
                        "TESTE@123"});
#line 77
  testRunner.And("preenche os campos com os valores", ((string)(null)), table6, "E ");
#line 84
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 85
  testRunner.Then("Recebe uma mensagem de erro de que a senha requer letra minuscula", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha sem caracter especial")]
        public virtual void CadastroDeAlunoComSenhaSemCaracterEspecial()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha sem caracter especial", ((string[])(null)));
#line 87
 this.ScenarioSetup(scenarioInfo);
#line 88
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 89
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table7.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table7.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table7.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table7.AddRow(new string[] {
                        "Senha",
                        "Teste123"});
            table7.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste123"});
#line 90
  testRunner.And("preenche os campos com os valores", ((string)(null)), table7, "E ");
#line 97
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 98
  testRunner.Then("Recebe uma mensagem de erro de que a senha requer caracter especial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha em tamanho inferior ao permitido")]
        public virtual void CadastroDeAlunoComSenhaEmTamanhoInferiorAoPermitido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha em tamanho inferior ao permitido", ((string[])(null)));
#line 100
 this.ScenarioSetup(scenarioInfo);
#line 101
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 102
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table8.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table8.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table8.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table8.AddRow(new string[] {
                        "Senha",
                        "Te123"});
            table8.AddRow(new string[] {
                        "RepitaSenha",
                        "Te123"});
#line 103
  testRunner.And("preenche os campos com os valores", ((string)(null)), table8, "E ");
#line 110
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 111
  testRunner.Then("Recebe uma mensagem de erro de que a senha esta em tamanho inferior ao permitido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Cadastrar um novo Aluno")]
        [Xunit.TraitAttribute("Description", "Cadastro de Aluno com Senha diferentes")]
        public virtual void CadastroDeAlunoComSenhaDiferentes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastro de Aluno com Senha diferentes", ((string[])(null)));
#line 114
 this.ScenarioSetup(scenarioInfo);
#line 115
  testRunner.Given("que o aluno está no site, na pagina inicial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 116
  testRunner.And("clica no link de registro", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Campo",
                        "Valor"});
            table9.AddRow(new string[] {
                        "Nome",
                        "Eduardo Pires"});
            table9.AddRow(new string[] {
                        "Email",
                        "contato@eduardopires.net.br"});
            table9.AddRow(new string[] {
                        "CPF",
                        "30390600822"});
            table9.AddRow(new string[] {
                        "Senha",
                        "Teste@123"});
            table9.AddRow(new string[] {
                        "RepitaSenha",
                        "Teste@133"});
#line 117
  testRunner.And("preenche os campos com os valores", ((string)(null)), table9, "E ");
#line 124
  testRunner.When("clicar no botao registrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 125
  testRunner.Then("Recebe uma mensagem de erro de que a senha estao diferentes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CadastrarUmNovoAlunoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CadastrarUmNovoAlunoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
