using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command Minimalhmgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"minimalhmgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nugetmergefixtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nugetmergefixtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependadotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependadotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SilMachineHcparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sil.machine.hcparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Snagitshare2imgur(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"snagitshare2imgur {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uepme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uepme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Renametool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"renametool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fileserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fileserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMiglifier(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-miglifier {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FarcasterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"farcaster.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gensummary(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gensummary {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqlservertomermaidtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqlservertomermaidtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Proxyswitcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"proxyswitcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Efbench(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"efbench {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVslint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-vslint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resourceversiongenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resourceversiongenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkDotnetrelease(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.dotnetrelease {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NetXleonIva(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"net.xleon.iva {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotenvTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotenv-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Jtrancmd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jtrancmd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projectversionupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectversionupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRequbex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-requbex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Projectgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LukevoRunonsave(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lukevo.runonsave {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command IpfsuploaderTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ipfsuploader.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sourcelinkextract(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sourcelinkextract {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTodo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-todo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OojaFrameworkMigrationsDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ooja.framework.migrations.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wan24I8ntool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wan24-i8ntool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MetafacProjscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metafac.projscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Exemplotechtalks(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"exemplotechtalks {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StrideStoragetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stride.storagetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SmmsUploader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"smms-uploader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ShaderLs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shader-ls {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Trxfilesystem(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"trxfilesystem {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Taskstak(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"taskstak {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevexpressMauiXamltools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devexpress.maui.xamltools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SylvanToolsEtl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sylvan.tools.etl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NakatomiOps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nakatomi.ops {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOldschoolI18n(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-oldschool-i18n {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command QwertyuiopDbupgrader(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qwertyuiop.dbupgrader {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hybridizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hybridizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ppzip(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ppzip {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Netenv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"netenv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Timemcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"timemcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Suo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"suo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qrcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qrcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Notecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"notecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Uecli(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"uecli {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DataskExcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"datask-excel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitStory(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"git-story {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Secretsanta(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"secretsanta {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RstolsmarkPasswordhashtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rstolsmark.passwordhashtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sika(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sika {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Reviveq(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"reviveq {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-trace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSos(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sos {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetStack(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-stack {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSvcutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-svcutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSymbol(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-symbol {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DafnyReportgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dafny-reportgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSuggest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-suggest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dafny(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dafny {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependensee(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependensee {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RnwoodSmtp4dev(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rnwood.smtp4dev {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DprojectsDish(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dprojects.dish {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MicrosoftDotnetMage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"microsoft.dotnet.mage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDsrouter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dsrouter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DgtPower(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dgt.power {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNodejs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nodejs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMergenupkg(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mergenupkg {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetExample(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-example {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetIlverify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ilverify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DkExpressionsShell(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dk.expressions.shell {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dhxcodetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dhxcodetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNlu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nlu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNodejsLinux(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nodejs-linux {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNodejsWin(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nodejs-win {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWtrace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-wtrace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHeapview(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-heapview {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MonorepoDependencymanager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"monorepo.dependencymanager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetKrp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-krp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetsimpleserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetsimpleserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dyndnsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dyndnsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPstree(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pstree {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Devmaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devmaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FreesqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"freesql.generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDashing(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-dashing {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dhstardeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dhstardeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Heroesdataparser(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"heroesdataparser {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UnofficialUrho3dnetEditor(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"unofficial.urho3dnet.editor {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVstemplate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-vstemplate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetdeployerTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetdeployer.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GenerateDataEndpointProxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"generate-data-endpoint-proxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNluMock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nlu-mock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TankaDocsgen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tanka.docsgen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetInnosetup(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-innosetup {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}