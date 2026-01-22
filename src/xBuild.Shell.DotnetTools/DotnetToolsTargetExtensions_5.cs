using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Fantomas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fantomas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Luisgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"luisgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ReferenceassemblygeneratorCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"referenceassemblygenerator.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arsub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arsub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aas(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aas {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAries(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-aries {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azloadcli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azloadcli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Adoscloneallrepos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adoscloneallrepos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Cute(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cute {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AliceRepl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alice-repl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MessagepackGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"messagepack.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Aspire2kubeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspire2kube.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltairisXml4webCompiler(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altairis.xml4web.compiler {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Avalonbuild(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avalonbuild {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DvoituronToolsAzureletsencrypt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dvoituron.tools.azureletsencrypt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Coders(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"coders {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Advocu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"advocu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsrtoolCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asrtool.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AdlianceTestplanexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"adliance.testplanexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CadmoCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cadmo-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AspnetcoreGenesistool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aspnetcore.genesistool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mkngoogleapiapp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mkngoogleapiapp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FakeCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fake-cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftPlaywrightCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.playwright.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlsApiCrudgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"als.api.crudgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PommalabsHtmlarkTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pommalabs.htmlark.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ChatroomOpenai(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"chatroom.openai {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NservicebusAmazonsqsCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nservicebus.amazonsqs.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Amusing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"amusing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntoAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anto.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Livereloadserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"livereloadserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmdnReflectionReversegeneratingListapi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smdn.reflection.reversegenerating.listapi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcukAwsCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acuk.aws.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltemiqSemanticversioning(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altemiq.semanticversioning {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pharmacist(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pharmacist {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appi(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appi {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MagnusoperaOpenapigen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"magnusopera.openapigen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApstoryTypescriptcodegenSwagger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apstory.typescriptcodegen.swagger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azureservicebusdlq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azureservicebusdlq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AndtechMarkoutConsole(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"andtech.markout.console {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAzure(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-azure {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Igloo15MarkdownapiTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"igloo15.markdownapi.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntosubashAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"antosubash.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SteffbeckersAbpCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"steffbeckers.abp.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftCstDevskimCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.cst.devskim.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetArgs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-args {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Addlicenseheader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"addlicenseheader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetuAttributes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metu.attributes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiParcelLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.parcel.linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Spex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ansiart(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ansiart {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Admxcodegen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"admxcodegen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RoramuDecouplerDotnetGeneratorApp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"roramu.decoupler.dotnet.generator.app {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApiInfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"api-info {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AvaloniauiParcelMacos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"avaloniaui.parcel.macos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MobileinspectorToolsAddmodel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mobileinspector.tools.addmodel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MasesKnetconnect(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mases.knetconnect {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlexwDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alexw.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AiursoftNetworktest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aiursoft.networktest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToolAwsCodedeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tool.aws.codedeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LabappsProjscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"labapps.projscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AntoVersionize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anto.versionize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AitsysPurrcryptCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"aitsys.purrcrypt.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApqCfgCryptoTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apq.cfg.crypto.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T CryptiklemurAssetbundlebuilder(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"cryptiklemur.assetbundlebuilder {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnjosoftCifra(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anjosoft.cifra {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ai2csprojTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ai2csproj.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StrawberryshakeTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strawberryshake.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MssqlAdapterCollector(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mssql.adapter.collector {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AcblogToolsSdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"acblog.tools.sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpanableskyapmDotnetCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spanableskyapm.dotnet.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YiAbpTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yi.abp.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SepAbpzCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sep.abpz.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenaiMock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openai.mock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ando(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ando {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fsdgenaspnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fsdgenaspnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Allclean(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"allclean {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arasdevelopertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arasdevelopertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AlexWolfPsRssfeedmcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"alex-wolf-ps.rssfeedmcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Codeanalyzertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"codeanalyzertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LivingdocumentationAnalyzer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"livingdocumentation.analyzer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AnvTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"anv.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AtcAzureDigitaltwin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atc-azure-digitaltwin {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PicklesCommandline(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pickles.commandline {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerGameserversAgent(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.gameservers.agent {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AsynkronTestrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"asynkron.testrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Arc4uCyphertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"arc4u.cyphertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AzureApiManagementDevopsResourceKit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azure-api-management-devops-resource-kit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T AltinnJwks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"altinn-jwks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Act2txt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"act2txt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Appmake(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"appmake {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Atarilynx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"atarilynx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Azuremigratedataextractor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"azuremigratedataextractor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Youtubearchiverserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"youtubearchiverserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetAppconfig(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-appconfig {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SyncfusionScaffolding(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"syncfusion.scaffolding {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UgtAbphelper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ugt.abphelper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T VerliteCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"verlite.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ApiandCli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"apiand.cli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetCertes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-certes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}