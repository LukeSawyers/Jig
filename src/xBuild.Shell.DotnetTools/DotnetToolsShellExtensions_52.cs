using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command RocketuiDesignHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rocketui.design.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSwitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-switch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XfuncDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xfunc.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docfxmarkdowngen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docfxmarkdowngen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDebuggerExtensions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-debugger-extensions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Docify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"docify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScipDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scip-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Easydotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"easydotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Depsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"depsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dependencyupdatertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependencyupdatertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetI18nTranslate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-i18n-translate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dtdl2Validator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dtdl2-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Designdocmarkuplanguage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"designdocmarkuplanguage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DuotifyMarkdowntranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"duotify.markdowntranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRuntimeinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-runtimeinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dataexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dataexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Digger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"digger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetRename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet.rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGimme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gimme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctopusOctoversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octopus.octoversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOutdatedNukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-outdated-nukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetWs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dllyaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dllyaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OperatorsharpToolsDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"operatorsharp.tools.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNperf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nperf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gitstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetKorea(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-korea {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetstatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetstatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFwpf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-fwpf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowDebuggerFireflysrv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.debugger.fireflysrv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-gf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetProjDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-proj-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dockervolumewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dockervolumewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SfDataexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sf-dataexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lsifdotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lsifdotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotdock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotdock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DevprimeTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"devprime.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dnsnoop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dnsnoop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ddc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ddc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNugetSources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nuget-sources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetVer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetToolRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tool-run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DpaOpcuaRs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dpa.opcua.rs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ProjectdiffTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"projectdiff.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Divoomtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"divoomtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Drw(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"drw {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTcloud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tcloud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command FtDatafangstTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ft.datafangst.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WfmScriptdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wfm.scriptdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dydoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dydoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gitdateversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitdateversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Thirdlicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"thirdlicense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetF5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-f5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetversionpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetversionpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMystique(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-mystique {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PhoesionGlowDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"phoesion.glow.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dotnetdacmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnetdacmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command LadeakGrpcproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ladeak.grpcproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deps2mermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deps2mermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetReleaseNote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-release-note {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetFindReplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-find-replace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetUps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-ups {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DimonsmartLocalollamamcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dimonsmart.localollamamcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetOnnx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-onnx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DworthenTaskrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dworthen.taskrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pgscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pgscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbvm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbvm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dumpe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dumpe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dcu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dcu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dviz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dviz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DiscordNetToolsLocalizationResx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"discord.net.tools.localization.resx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DependabotPrManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dependabot-pr-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetNrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-nrm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetHandle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-handle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetZipSource(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-zip-source {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dummylogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dummylogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command EmergingDb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"emerging-db {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dispatchergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dispatchergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OctoversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"octoversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetTidy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-tidy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotsefSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotsef-sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JacdacDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jacdac.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetListProcess(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-list-process {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-sdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DiscordNetToolsLocalizationJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"discord.net.tools.localization.json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command JjconsultingDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"jjconsulting.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Deepren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"deepren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetSlugentExampletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-slugent-exampletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Dbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPacman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-pacman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetPrepare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-prepare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetGitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-git-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DbexpressionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dbexpression.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetMessageValidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-message-validation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command DotnetImooc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"dotnet-imooc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UpdevsSdkGenerators(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"updevs.sdk.generators {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}