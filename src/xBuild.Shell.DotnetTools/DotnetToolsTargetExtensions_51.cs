using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T Minimalhmgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"minimalhmgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nugetmergefixtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nugetmergefixtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependadotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependadotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SilMachineHcparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sil.machine.hcparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Snagitshare2imgur(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"snagitshare2imgur {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uepme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uepme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Renametool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"renametool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fileserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fileserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMiglifier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-miglifier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FarcasterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"farcaster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gensummary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gensummary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqlservertomermaidtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqlservertomermaidtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Proxyswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"proxyswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Efbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"efbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-vslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resourceversiongenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resourceversiongenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkDotnetrelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.dotnetrelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NetXleonIva(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"net.xleon.iva {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotenvTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotenv-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Jtrancmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jtrancmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projectversionupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectversionupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRequbex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-requbex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Projectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LukevoRunonsave(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lukevo.runonsave {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T IpfsuploaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ipfsuploader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sourcelinkextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sourcelinkextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTodo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OojaFrameworkMigrationsDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ooja.framework.migrations.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wan24I8ntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wan24-i8ntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MetafacProjscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metafac.projscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Exemplotechtalks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"exemplotechtalks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StrideStoragetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stride.storagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SmmsUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"smms-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ShaderLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shader-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Trxfilesystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"trxfilesystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Taskstak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"taskstak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevexpressMauiXamltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devexpress.maui.xamltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SylvanToolsEtl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sylvan.tools.etl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NakatomiOps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nakatomi.ops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOldschoolI18n(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-oldschool-i18n {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T QwertyuiopDbupgrader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qwertyuiop.dbupgrader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hybridizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hybridizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ppzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ppzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Netenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"netenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Timemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"timemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Suo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"suo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qrcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qrcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Notecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"notecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Uecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"uecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DataskExcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"datask-excel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitStory(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"git-story {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Secretsanta(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"secretsanta {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RstolsmarkPasswordhashtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rstolsmark.passwordhashtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Reviveq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"reviveq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetStack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-stack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-svcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSymbol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-symbol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DafnyReportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dafny-reportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSuggest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-suggest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dafny(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dafny {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependensee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependensee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RnwoodSmtp4dev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rnwood.smtp4dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DprojectsDish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dprojects.dish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MicrosoftDotnetMage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"microsoft.dotnet.mage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDsrouter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dsrouter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DgtPower(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dgt.power {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNodejs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nodejs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMergenupkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mergenupkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetIlverify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ilverify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DkExpressionsShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dk.expressions.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dhxcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dhxcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNlu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nlu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNodejsLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nodejs-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNodejsWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nodejs-win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWtrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-wtrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHeapview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-heapview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MonorepoDependencymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"monorepo.dependencymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetKrp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-krp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetsimpleserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetsimpleserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dyndnsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dyndnsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPstree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pstree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Devmaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devmaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FreesqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"freesql.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDashing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-dashing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dhstardeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dhstardeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Heroesdataparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"heroesdataparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UnofficialUrho3dnetEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"unofficial.urho3dnet.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVstemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-vstemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetdeployerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetdeployer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GenerateDataEndpointProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"generate-data-endpoint-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNluMock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nlu-mock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TankaDocsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tanka.docsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetInnosetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-innosetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}