using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Fantomas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fantomas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Luisgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"luisgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ReferenceassemblygeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"referenceassemblygenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arsub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arsub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAries(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-aries {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azloadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azloadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Adoscloneallrepos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adoscloneallrepos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Cute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AliceRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alice-repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MessagepackGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"messagepack.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Aspire2kubeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspire2kube.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltairisXml4webCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altairis.xml4web.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Avalonbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avalonbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DvoituronToolsAzureletsencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dvoituron.tools.azureletsencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Coders(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"coders {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Advocu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"advocu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsrtoolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asrtool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AdlianceTestplanexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"adliance.testplanexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CadmoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cadmo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AspnetcoreGenesistool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aspnetcore.genesistool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mkngoogleapiapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mkngoogleapiapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FakeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fake-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftPlaywrightCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.playwright.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlsApiCrudgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"als.api.crudgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PommalabsHtmlarkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pommalabs.htmlark.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ChatroomOpenai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"chatroom.openai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NservicebusAmazonsqsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nservicebus.amazonsqs.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Amusing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"amusing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntoAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anto.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Livereloadserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"livereloadserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmdnReflectionReversegeneratingListapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smdn.reflection.reversegenerating.listapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcukAwsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acuk.aws.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltemiqSemanticversioning(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altemiq.semanticversioning {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pharmacist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pharmacist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MagnusoperaOpenapigen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"magnusopera.openapigen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApstoryTypescriptcodegenSwagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apstory.typescriptcodegen.swagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azureservicebusdlq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azureservicebusdlq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AndtechMarkoutConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"andtech.markout.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAzure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-azure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Igloo15MarkdownapiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"igloo15.markdownapi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntosubashAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"antosubash.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SteffbeckersAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"steffbeckers.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftCstDevskimCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.cst.devskim.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetArgs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-args {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Addlicenseheader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"addlicenseheader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetuAttributes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metu.attributes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiParcelLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.parcel.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Spex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ansiart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ansiart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Admxcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"admxcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RoramuDecouplerDotnetGeneratorApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"roramu.decoupler.dotnet.generator.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApiInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"api-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AvaloniauiParcelMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"avaloniaui.parcel.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MobileinspectorToolsAddmodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mobileinspector.tools.addmodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MasesKnetconnect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mases.knetconnect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlexwDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alexw.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AiursoftNetworktest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aiursoft.networktest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToolAwsCodedeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tool.aws.codedeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LabappsProjscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"labapps.projscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AntoVersionize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anto.versionize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AitsysPurrcryptCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"aitsys.purrcrypt.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApqCfgCryptoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apq.cfg.crypto.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command CryptiklemurAssetbundlebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"cryptiklemur.assetbundlebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnjosoftCifra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anjosoft.cifra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ai2csprojTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ai2csproj.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MssqlAdapterCollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mssql.adapter.collector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AcblogToolsSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"acblog.tools.sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpanableskyapmDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spanableskyapm.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YiAbpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yi.abp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SepAbpzCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sep.abpz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenaiMock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openai.mock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ando(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ando {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fsdgenaspnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fsdgenaspnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Allclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"allclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arasdevelopertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arasdevelopertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AlexWolfPsRssfeedmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"alex-wolf-ps.rssfeedmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Codeanalyzertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"codeanalyzertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LivingdocumentationAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"livingdocumentation.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AnvTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"anv.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AtcAzureDigitaltwin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atc-azure-digitaltwin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PicklesCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pickles.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerGameserversAgent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.gameservers.agent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AsynkronTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"asynkron.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Arc4uCyphertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"arc4u.cyphertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AzureApiManagementDevopsResourceKit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azure-api-management-devops-resource-kit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command AltinnJwks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"altinn-jwks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Act2txt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"act2txt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Appmake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"appmake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Atarilynx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"atarilynx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Azuremigratedataextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"azuremigratedataextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Youtubearchiverserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"youtubearchiverserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetAppconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-appconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SyncfusionScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"syncfusion.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UgtAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ugt.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command VerliteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"verlite.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ApiandCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"apiand.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetCertes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-certes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}