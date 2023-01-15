using ClangFormatEditor.Enums;
using ClangFormatEditor.Interfaces;
using ClangFormatEditor.MVVM.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClangFormatEditor
{
  public class FormatOptionsAllData
  {
    static int CLangVersion(int major, int minor = 0) => (major << 8) + minor;

    public Dictionary<string, IFormatOption> FormatOptions { get; set; } = new()
    {
      {
        "AccessModifierOffset",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 3),
          Name = "AccessModifierOffset",
          Paramater = "int",
          Description = "The extra indent or outdent of access modifiers, e.g. \"public:\"",
          Input = "-2"
        }
      },
      {
        "AlignAfterOpenBracket",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 8),
          Name = "AlignAfterOpenBracket",
          Paramater = "BracketAlignmentStyle",
          Description = "If \"true\", horizontally aligns arguments after an open bracket.\r\nThis applies to round brackets (parentheses), angle brackets and square brackets.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BAS_Align", Value = "Align", Description = "Align parameters on the open bracket" },
            new FormatOptionSelectModelValue { Name = "BAS_DontAlign", Value = "DontAlign", Description = "Don’t align, instead use ContinuationIndentWidth" },
            new FormatOptionSelectModelValue { Name = "BAS_AlwaysBreak", Value = "AlwaysBreak", Description = "Always break after an open bracket, if the parameters don’t fit on a single line" },
            new FormatOptionSelectModelValue { Name = "BAS_BlockIndent", Value = "BlockIndent", Description = "Always break after an open bracket, if the parameters don’t fit on a single line. Closing brackets will be placed on a new line" },
          },
          Input = "Align"
        }
      },
      {
        "AlignArrayOfStructures",
        new FormatOptionSelectModel {
          Version = CLangVersion(13),
          Name = "AlignArrayOfStructures",
          Paramater = "ArrayInitializerAlignmentStyle",
          Description = "if not None, when using initialization for an array of structs aligns the fields into columns.\r\n"
                      + "NOTE: As of clang-format 15 this option only applied to arrays with equal number of columns per row.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "AIAS_Left", Value = "Left", Description = "Align array column and left justify the columns" },
            new FormatOptionSelectModelValue { Name = "AIAS_Right", Value = "Right", Description = "Align array column and right justify the columns" },
            new FormatOptionSelectModelValue { Name = "AIAS_None", Value = "None", Description = "Don’t align array initializer columns" },
          },
          Input = "None"
        }
      },
      {
        "AlignConsecutiveAssignments",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 8),
          Name = "AlignConsecutiveAssignments",
          Paramater = "AlignConsecutiveStyle",
          Description = "Style of aligning consecutive assignments.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ACS_None", Value = "None", Description = "Do not align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_Consecutive", Value = "Consecutive", Description = "Align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLines", Value = "AcrossEmptyLines", Description = "Same as ACS_Consecutive, but also spans over empty lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossComments", Value = "AcrossComments", Description = "Same as ACS_Consecutive, but also spans over comments" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLinesAndComments", Value = "AcrossEmptyLinesAndComments", Description = "Same as ACS_Consecutive, but also spans over comments and empty lines" },
          },
          Input = "None"
        }
      },
      {
        "AlignConsecutiveBitFields",
        new FormatOptionSelectModel {
          Version = CLangVersion(11),
          Name = "AlignConsecutiveBitFields",
          Paramater = "AlignConsecutiveStyle",
          Description = "Style of aligning consecutive bit field.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ACS_None", Value = "None", Description = "Do not align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_Consecutive", Value = "Consecutive", Description = "Align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLines", Value = "AcrossEmptyLines", Description = "Same as ACS_Consecutive, but also spans over empty lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossComments", Value = "AcrossComments", Description = "Same as ACS_Consecutive, but also spans over comments" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLinesAndComments", Value = "AcrossEmptyLinesAndComments", Description = "Same as ACS_Consecutive, but also spans over comments and empty lines" },
          },
          Input = "None"
        }
      },
      {
        "AlignConsecutiveDeclarations",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 8),
          Name = "AlignConsecutiveDeclarations",
          Paramater = "AlignConsecutiveStyle",
          Description = "Style of aligning consecutive declarations.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ACS_None", Value = "None", Description = "Do not align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_Consecutive", Value = "Consecutive", Description = "Align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLines", Value = "AcrossEmptyLines", Description = "Same as ACS_Consecutive, but also spans over empty lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossComments", Value = "AcrossComments", Description = "Same as ACS_Consecutive, but also spans over comments" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLinesAndComments", Value = "AcrossEmptyLinesAndComments", Description = "Same as ACS_Consecutive, but also spans over comments and empty lines" },
          },
          Input = "None"
        }
      },
      {
        "AlignConsecutiveMacros",
        new FormatOptionSelectModel {
          Version = CLangVersion(9),
          Name = "AlignConsecutiveMacros",
          Paramater = "AlignConsecutiveStyle",
          Description = "Style of aligning consecutive macro definitions.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ACS_None", Value = "None", Description = "Do not align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_Consecutive", Value = "Consecutive", Description = "Align assignments on consecutive lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLines", Value = "AcrossEmptyLines", Description = "Same as ACS_Consecutive, but also spans over empty lines" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossComments", Value = "AcrossComments", Description = "Same as ACS_Consecutive, but also spans over comments" },
            new FormatOptionSelectModelValue { Name = "ACS_AcrossEmptyLinesAndComments", Value = "AcrossEmptyLinesAndComments", Description = "Same as ACS_Consecutive, but also spans over comments and empty lines" },
          },
          Input = "None"
        }
      },
      {
        "AlignEscapedNewlines",
        new FormatOptionSelectModel {
          Version = CLangVersion(5),
          Name = "AlignEscapedNewlines",
          Paramater = "EscapedNewlineAlignmentStyle",
          Description = "Options for aligning backslashes in escaped newlines.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ENAS_DontAlign", Value = "DontAlign", Description = "Don’t align escaped newlines" },
            new FormatOptionSelectModelValue { Name = "ENAS_Left", Value = "Left", Description = "Align escaped newlines as far left as possible" },
            new FormatOptionSelectModelValue { Name = "ENAS_Right", Value = "Right", Description = "Align escaped newlines in the right-most column" }
          },
          Input = "Right"
        }
      },
      {
        "AlignOperands",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 5),
          Name = "AlignOperands",
          Paramater = "OperandAlignmentStyle",
          Description = "Horizontally align operands of binary and ternary expressions.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "OAS_DontAlign", Value = "DontAlign", Description = "Do not align operands of binary and ternary expressions" },
            new FormatOptionSelectModelValue { Name = "OAS_Align", Value = "Align", Description = "Horizontally align operands of binary and ternary expressions" },
            new FormatOptionSelectModelValue { Name = "OAS_AlignAfterOperator", Value = "AlignAfterOperator", Description = "Horizontally align operands of binary and ternary expression" }
          },
          Input = "Align"
        }
      },
      {
        "AlignTrailingComments",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "AlignTrailingComments",
          Paramater = "bool",
          Description = "If \"true\", aligns trailing comments",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "AllowAllArgumentsOnNextLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(9),
          Name = "AllowAllArgumentsOnNextLine",
          Paramater = "bool",
          Description = "If a function call or braced initializer list doesn’t fit on a line, allow putting all arguments onto the next line, even if BinPackArguments is false.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "AllowAllConstructorInitializersOnNextLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(9),
          Deprecated = CLangVersion(14),
          Name = "AllowAllConstructorInitializersOnNextLine",
          Paramater = "bool",
          Description = "If a constructor definition with a member initializer list doesn’t fit on a single line, allow putting all member initializers onto the next line, if `ConstructorInitializerAllOnOneLineOrOnePerLine` is true. Note that this parameter has no effect if `ConstructorInitializerAllOnOneLineOrOnePerLine` is false.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "AllowAllParametersOfDeclarationOnNextLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 3),
          Name = "AllowAllParametersOfDeclarationOnNextLine",
          Paramater = "bool",
          Description = "If the function declaration doesn’t fit on a line, allow putting all parameters of a function declaration onto the next line even if BinPackParameters is false.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "AllowShortBlocksOnASingleLine",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 5),
          Name = "AllowShortBlocksOnASingleLine",
          Paramater = "ShortBlockStyle",
          Description = "Dependent on the value, while (true) { continue; } can be put on a single line.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SBS_Never", Value = "Never", Description = "Never merge blocks into a single line" },
            new FormatOptionSelectModelValue { Name = "SBS_Empty", Value = "Empty", Description = "Only merge empty blocks" },
            new FormatOptionSelectModelValue { Name = "SBS_Always", Value = "Always", Description = "Always merge short blocks into a single line" }
          },
          Input = "Never"
        }
      },
      {
        "AllowShortCaseLabelsOnASingleLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 6),
          Name = "AllowShortCaseLabelsOnASingleLine",
          Paramater = "bool",
          Description = "If \"true\", short case labels will be contracted to a single line.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "AllowShortEnumsOnASingleLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(11),
          Name = "AllowShortEnumsOnASingleLine",
          Paramater = "bool",
          Description = "Allow short enums on a single line.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "AllowShortFunctionsOnASingleLine",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 5),
          Name = "AllowShortFunctionsOnASingleLine",
          Paramater = "ShortFunctionStyle",
          Description = "Dependent on the value, int f() { return 0; } can be put on a single line.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SFS_None", Value = "None", Description = "Never merge functions into a single line" },
            new FormatOptionSelectModelValue { Name = "SFS_InlineOnly", Value = "InlineOnly", Description = "Only merge functions defined inside a class. Same as “inline”, except it does not implies “empty”: i.e. top level empty functions are not merged either" },
            new FormatOptionSelectModelValue { Name = "SFS_Empty", Value = "Empty", Description = "Only merge empty functions" },
            new FormatOptionSelectModelValue { Name = "SFS_Inline", Value = "Inline", Description = "Only merge functions defined inside a class. Implies “empty”" },
            new FormatOptionSelectModelValue { Name = "SFS_All", Value = "All", Description = "Merge all functions fitting on a single line" }
          },
          Input = "All"
        }
      },
      {
        "AllowShortIfStatementsOnASingleLine",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 3),
          Name = "AllowShortIfStatementsOnASingleLine",
          Paramater = "ShortIfStyle",
          Description = "If true, if (a) return; can be put on a single line.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SIS_Never", Value = "Never", Description = "Never put short ifs on the same line" },
            new FormatOptionSelectModelValue { Name = "SIS_WithoutElse", Value = "WithoutElse", Description = "Without else put short ifs on the same line only if the else is not a compound statement" },
            new FormatOptionSelectModelValue { Name = "SIS_Always", Value = "Always", Description = "Always put short ifs on the same line if the else is not a compound statement or not" },
          },
          Input = "Never"
        }
      },
      {
        "AllowShortLambdasOnASingleLine",
        new FormatOptionSelectModel {
          Version = CLangVersion(9),
          Name = "AllowShortLambdasOnASingleLine",
          Paramater = "ShortLambdaStyle",
          Description = "Dependent on the value, auto lambda []() { return 0; } can be put on a single line.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SLS_None", Value = "None", Description = "Never merge lambdas into a single line" },
            new FormatOptionSelectModelValue { Name = "SLS_Empty", Value = "Empty", Description = "Only merge empty lambdas" },
            new FormatOptionSelectModelValue { Name = "SLS_Inline", Value = "Inline", Description = "Merge lambda into a single line if argument of a function" },
            new FormatOptionSelectModelValue { Name = "SLS_All", Value = "All", Description = "Merge all lambdas fitting on a single line" },
          },
          Input = "All"
        }
      },
      {
        "AllowShortLoopsOnASingleLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "AllowShortLoopsOnASingleLine",
          Paramater = "bool",
          Description = "If true, while (true) continue; can be put on a single line.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "AlwaysBreakAfterDefinitionReturnType",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 7),
          Deprecated = CLangVersion(3, 8),
          Name = "AlwaysBreakAfterDefinitionReturnType",
          Paramater = "DefinitionReturnTypeBreakingStyle",
          Description = "The function definition return type breaking style to use. This option is deprecated and is retained for backwards compatibility.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "DRTBS_None", Value = "None", Description = "Break after return type automatically. PenaltyReturnTypeOnItsOwnLine is taken into account" },
            new FormatOptionSelectModelValue { Name = "DRTBS_All", Value = "All", Description = "Always break after the return type" },
            new FormatOptionSelectModelValue { Name = "DRTBS_TopLevel", Value = "TopLevel", Description = "Always break after the return types of top-level functions" },
          },
          Input = "All"
        }
      },
      {
        "AlwaysBreakAfterReturnType",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 8),
          Name = "AlwaysBreakAfterReturnType",
          Paramater = "ReturnTypeBreakingStyle",
          Description = "The function declaration return type breaking style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "RTBS_None", Value = "None", Description = "Break after return type automatically. PenaltyReturnTypeOnItsOwnLine is taken into account" },
            new FormatOptionSelectModelValue { Name = "RTBS_All", Value = "All", Description = "Always break after the return type" },
            new FormatOptionSelectModelValue { Name = "RTBS_TopLevel", Value = "TopLevel", Description = "Always break after the return types of top-level functions" },
            new FormatOptionSelectModelValue { Name = "RTBS_AllDefinitions", Value = "AllDefinitions", Description = "Always break after the return type of function definitions" },
            new FormatOptionSelectModelValue { Name = "RTBS_TopLevelDefinitions", Value = "TopLevelDefinitions", Description = "Always break after the return type of top-level definitions" },
          },
          Input = "None"
        }
      },
      {
        "AlwaysBreakBeforeMultilineStrings",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 4),
          Name = "AlwaysBreakBeforeMultilineStrings",
          Paramater = "bool",
          Description = "If true, always break before multiline string literals.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "AlwaysBreakTemplateDeclarations",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 4),
          Name = "AlwaysBreakTemplateDeclarations",
          Paramater = "BreakTemplateDeclarationsStyle",
          Description = "The template declaration breaking style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BTDS_No", Value = "No", Description = "Do not force break before declaration. PenaltyBreakTemplateDeclaration is taken into account" },
            new FormatOptionSelectModelValue { Name = "BTDS_MultiLine", Value = "MultiLine", Description = "Force break after template declaration only when the following declaration spans multiple lines" },
            new FormatOptionSelectModelValue { Name = "BTDS_Yes", Value = "Yes", Description = "Always break after template declaration" },
          },
          Input = "MultiLine"
        }
      },
      {
        "AttributeMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(12),
          Name = "AttributeMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of strings that should be interpreted as attributes/qualifiers instead of identifiers. This can be useful for language extensions or static analyzer annotations.",
          MultipleInput = "- __capability"
        }
      },
      {
        "BasedOnStyle",
        new FormatOptionSelectModel {
          Name = "BasedOnStyle",
          Paramater = "string",
          Description = "The style used for all options not specifically set in the configuration.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "LLVM", Value = "LLVM", Description = "LLVM style" },
            new FormatOptionSelectModelValue { Name = "Google", Value = "Google", Description = "Google style" },
            new FormatOptionSelectModelValue { Name = "Chromium", Value = "Chromium", Description = "Chromium style" },
            new FormatOptionSelectModelValue { Name = "Mozilla", Value = "Mozilla", Description = "Mozilla style" },
            new FormatOptionSelectModelValue { Name = "WebKit", Value = "WebKit", Description = "WebKit style" },
            new FormatOptionSelectModelValue { Name = "Microsoft", Value = "Microsoft", Description = "Microsoft style" },
            new FormatOptionSelectModelValue { Name = "GNU", Value = "GNU", Description = "Microsoft style" }
          },
          Input = ""
        }
      },
      {
        "BinPackArguments",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "BinPackArguments",
          Paramater = "bool",
          Description = "If \"false\", a function declaration’s or function definition’s parameters will either all be on the same line or will have one line each.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "BinPackParameters",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "BinPackParameters",
          Paramater = "bool",
          Description = "If \"false\", a function declaration’s or function definition’s parameters will either all be on the same line or will have one line each.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "BitFieldColonSpacing",
        new FormatOptionSelectModel {
          Version = CLangVersion(12),
          Name = "BitFieldColonSpacing",
          Paramater = "BitFieldColonSpacingStyle",
          Description = "The BitFieldColonSpacingStyle to use for bitfields.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BFCS_Both", Value = "Both", Description = "Add one space on each side of the :" },
            new FormatOptionSelectModelValue { Name = "BFCS_None", Value = "None", Description = "Add no space around the : (except when needed for AlignConsecutiveBitFields)" },
            new FormatOptionSelectModelValue { Name = "BFCS_Before", Value = "Before", Description = "Add space before the : only" },
            new FormatOptionSelectModelValue { Name = "BFCS_After", Value = "After", Description = "Add space after the : only (space may be added before if needed for AlignConsecutiveBitFields)" },
          },
          Input = "None"
        }
      },
      {
        "BraceWrapping",
        new FormatOptionMultipleToggleModel {
          Version = CLangVersion(3, 8),
          Name = "BraceWrapping",
          Paramater = "BraceWrappingFlags",
          Description = "Control of individual brace wrapping cases.\r\n If BreakBeforeBraces is set to BS_Custom, use this to specify how each individual brace case should be handled. Otherwise, this is ignored.",
          ToggleFlags = new List<ToggleModel>() {
            new ToggleModel("AfterCaseLabel", ToggleValues.False),
            new ToggleModel("AfterClass", ToggleValues.False),
            new ToggleModel("AfterControlStatement", ToggleValues.False),
            new ToggleModel("AfterEnum", ToggleValues.False),
            new ToggleModel("AfterFunction", ToggleValues.False),
            new ToggleModel("AfterNamespace", ToggleValues.False),
            new ToggleModel("AfterObjCDeclaration", ToggleValues.False),
            new ToggleModel("AfterStruct", ToggleValues.False),
            new ToggleModel("AfterUnion", ToggleValues.False),
            new ToggleModel("AfterExternBlock", ToggleValues.False),
            new ToggleModel("BeforeCatch", ToggleValues.False),
            new ToggleModel("BeforeElse", ToggleValues.False),
            new ToggleModel("IndentBraces", ToggleValues.False),
            new ToggleModel("SplitEmptyFunction", ToggleValues.False),
            new ToggleModel("SplitEmptyRecord", ToggleValues.False),
            new ToggleModel("SplitEmptyNamespace", ToggleValues.False),
            new ToggleModel("BeforeLambdaBody", ToggleValues.False),
            new ToggleModel("BeforeWhile", ToggleValues.False)
          }
        }
      },
      {
        "BreakAfterAttributes",
        new FormatOptionSelectModel {
          Version = CLangVersion(16),
          Name = "BreakAfterAttributes",
          Paramater = "AttributeBreakingStyle",
          Description = "Break after a group of C++11 attributes before a function declaration/definition name.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ABS_Always", Value = "Always", Description = "Always break after attributes" },
            new FormatOptionSelectModelValue { Name = "ABS_Leave", Value = "Leave", Description = "Leave the line breaking after attributes as is" },
            new FormatOptionSelectModelValue { Name = "ABS_Never", Value = "Never", Description = "Never break after attributes" },
          },
          Input = "Never"
        }
      },
      {
        "BreakAfterJavaFieldAnnotations",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 8),
          Name = "BreakAfterJavaFieldAnnotations",
          Paramater = "bool",
          Description = "Break after each annotation on a field in Java files",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "BreakArrays",
        new FormatOptionToggleModel {
          Version = CLangVersion(16),
          Name = "BreakArrays",
          Paramater = "bool",
          Description = "If true, clang-format will always break after a Json array [ otherwise it will scan until the closing ] to determine if it should add newlines between elements (prettier compatible).",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "BreakBeforeBinaryOperators",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 8),
          Name = "BreakBeforeBinaryOperators",
          Paramater = "BinaryOperatorStyle",
          Description = "The way to wrap binary operators.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BOS_None", Value = "None", Description = "Break after operators" },
            new FormatOptionSelectModelValue { Name = "BOS_NonAssignment", Value = "NonAssignment", Description = "Break before operators that aren’t assignments" },
            new FormatOptionSelectModelValue { Name = "BOS_All", Value = "All", Description = "Break before operators" },
          },
          Input = "None"
        }
      },
      {
        "BreakBeforeBraces",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 7),
          Name = "BreakBeforeBraces",
          Paramater = "BraceBreakingStyle",
          Description = "The brace breaking style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BS_Attach", Value = "Attach", Description = "Always attach braces to surrounding context" },
            new FormatOptionSelectModelValue { Name = "BS_Linux", Value = "Linux", Description = "Like Attach, but break before braces on function, namespace and class definitions" },
            new FormatOptionSelectModelValue { Name = "BS_Mozilla", Value = "Mozilla", Description = "Like Attach, but break before braces on enum, function, and record definitions" },
            new FormatOptionSelectModelValue { Name = "BS_Stroustrup", Value = "Stroustrup", Description = "Like Attach, but break before function definitions" },
            new FormatOptionSelectModelValue { Name = "BS_Allman", Value = "Allman", Description = "Always break before braces" },
            new FormatOptionSelectModelValue { Name = "BS_Whitesmiths", Value = "Whitesmiths", Description = "Like Allman but always indent braces and line up code with braces" },
            new FormatOptionSelectModelValue { Name = "BS_GNU", Value = "GNU", Description = "Always break before braces and add an extra level of indentation to braces of control statements, not to those of class, function or other definitions" },
            new FormatOptionSelectModelValue { Name = "BS_WebKit", Value = "WebKit", Description = "Like Attach, but break before functions" },
            new FormatOptionSelectModelValue { Name = "BS_Custom", Value = "Custom", Description = "Configure each individual brace in BraceWrapping" },
          },
          Input = "Attach"
        }
      },
      {
        "BreakBeforeConceptDeclarations",
        new FormatOptionSelectModel {
          Version = CLangVersion(12),
          Name = "BreakBeforeConceptDeclarations",
          Paramater = "BreakBeforeConceptDeclarationsStyle",
          Description = "The concept declaration style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BBCDS_Never", Value = "Never", Description = "Keep the template declaration line together with concept" },
            new FormatOptionSelectModelValue { Name = "BBCDS_Allowed", Value = "Allowed", Description = "Breaking between template declaration and concept is allowed. The actual behavior depends on the content and line breaking rules and penalities" },
            new FormatOptionSelectModelValue { Name = "BBCDS_Always", Value = "Always", Description = "Always break before concept, putting it in the line after the template declaration" },
          },
          Input = "Never"
        }
      },
      {
        "BreakBeforeInlineASMColon",
        new FormatOptionSelectModel {
          Version = CLangVersion(16),
          Name = "BreakBeforeInlineASMColon",
          Paramater = "BreakBeforeInlineASMColonStyle",
          Description = "The inline ASM colon style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BBIAS_Never", Value = "Never", Description = "No break before inline ASM colon" },
            new FormatOptionSelectModelValue { Name = "BBIAS_OnlyMultiline", Value = "OnlyMultiline", Description = "Break before inline ASM colon if the line length is longer than column limit" },
            new FormatOptionSelectModelValue { Name = "BBIAS_Always", Value = "Always", Description = "Always break before inline ASM colon" },
          },
          Input = "Never"
        }
      },
      {
        "BreakBeforeTernaryOperators",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "BreakBeforeTernaryOperators",
          Paramater = "bool",
          Description = "If true, ternary operators will be placed after line breaks.",
          BooleanCombobox = ToggleValues.True
        }
      },
      /* Removed from clang-format ? not in doc anymore https://clang.llvm.org/docs/ClangFormatStyleOptions.html
      {
        "BreakBeforeInheritanceComma",
        new FormatOptionToggleModel {
          Name = "BreakBeforeInheritanceComma",
          Paramater = "bool",
          Description = "If \"true\",  in the class inheritance expression clang-format will break before : and , if there is multiple inheritance.",
          BooleanCombobox = ToggleValues.False
        }
      },
      */
      {
        "BreakConstructorInitializers",
        new FormatOptionSelectModel {
          Version = CLangVersion(5),
          Name = "BreakConstructorInitializers",
          Paramater = "BreakConstructorInitializersStyle",
          Description = "The constructor initializers style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BCIS_BeforeColon", Value = "BeforeColon", Description = "Break constructor initializers before the colon and after the commas" },
            new FormatOptionSelectModelValue { Name = "BCIS_BeforeComma", Value = "BeforeComma", Description = "Break constructor initializers before the colon and commas, and align the commas with the colon" },
            new FormatOptionSelectModelValue { Name = "BCIS_AfterColon", Value = "AfterColon", Description = "Break constructor initializers after the colon and commas" },
          },
          Input = "BeforeColon"
        }
      },
      {
        "BreakInheritanceList",
        new FormatOptionSelectModel {
          Version = CLangVersion(7),
          Name = "BreakInheritanceList",
          Paramater = "BreakInheritanceListStyle",
          Description = "The inheritance list style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BILS_BeforeColon", Value = "BeforeColon", Description = "Break inheritance list before the colon and after the commas" },
            new FormatOptionSelectModelValue { Name = "BILS_BeforeComma", Value = "BeforeComma", Description = "Break inheritance list before the colon and commas, and align the commas with the colon" },
            new FormatOptionSelectModelValue { Name = "BILS_AfterColon", Value = "AfterColon", Description = "Break inheritance list after the colon and commas" },
          },
          Input = "BeforeColon"
        }
      },
      {
        "BreakStringLiterals",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 9),
          Name = "BreakStringLiterals",
          Paramater = "bool",
          Description = "Allow breaking string literals when formatting.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "ColumnLimit",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "ColumnLimit",
          Paramater = "unsigned",
          Description = "The column limit.\r\n"
                      + "A column limit of 0 means that there is no column limit. In this case, clang-format will respect the input’s line breaking decisions within statements unless they contradict other rules",
          Input = "80"
        }
      },
      {
        "CommentPragmas",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "CommentPragmas",
          Paramater = "std::string",
          Description = "A regular expression that describes comments with special meaning, which should not be split into lines or otherwise changed.",
          Input = "'^ IWYU pragma:'"
        }
      },
      {
        "CompactNamespaces",
        new FormatOptionToggleModel {
          Version = CLangVersion(5),
          Name = "CompactNamespaces",
          Paramater = "bool",
          Description = "If \"true\", consecutive namespace declarations will be on the same line. If false, each namespace is declared on a new line.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "ConstructorInitializerAllOnOneLineOrOnePerLine",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Deprecated = CLangVersion(14),
          Name = "ConstructorInitializerAllOnOneLineOrOnePerLine",
          Paramater = "bool",
          Description = "If the constructor initializers don’t fit on a line, put each initializer on its own line",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "ConstructorInitializerIndentWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "ConstructorInitializerIndentWidth",
          Paramater = "unsigned",
          Description = "The number of characters to use for indentation of constructor initializer lists.",
          Input = "4"
        }
      },
      {
        "ContinuationIndentWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "ContinuationIndentWidth",
          Paramater = "unsigned",
          Description = "Indent width for line continuations",
          Input = "4"
        }
      },
      {
        "Cpp11BracedListStyle",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 4),
          Name = "Cpp11BracedListStyle",
          Paramater = "bool",
          Description = "If true, format braced lists as best suited for C++11 braced lists.\r\nImportant differences: - No spaces inside the braced list. - No line break before the closing brace. - Indentation with the continuation indent, not with the block indent\r\nFundamentally, C++11 braced lists are formatted exactly like function calls would be formatted in their place. If the braced list follows a name (e.g. a type or variable name), clang-format formats as if the {} were the parentheses of a function call with that name. If there is no name, a zero-length name is assumed.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "DeriveLineEnding",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Deprecated = CLangVersion(16),
          Name = "DeriveLineEnding",
          Paramater = "bool",
          Description = "Analyze the formatted file for the most used line ending (\\r\\n or \\n). UseCRLF is only used as a fallback if none can be derived",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "DerivePointerAlignment",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "DerivePointerAlignment",
          Paramater = "bool",
          Description = "If \"true\", analyze the formatted file for the most common alignment of & and *. Pointer and reference alignment styles are going to be updated according to the preferences found in the file. PointerAlignment is then used only as fallback",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "EmptyLineAfterAccessModifier",
        new FormatOptionSelectModel {
          Version = CLangVersion(13),
          Name = "EmptyLineAfterAccessModifier",
          Paramater = "EmptyLineAfterAccessModifierStyle",
          Description = "Defines when to put an empty line after access modifiers. EmptyLineBeforeAccessModifier configuration handles the number of empty lines between two access modifiers.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ELAAMS_Never", Value = "Never", Description = "Remove all empty lines after access modifiers" },
            new FormatOptionSelectModelValue { Name = "ELAAMS_Leave", Value = "Leave", Description = "Keep existing empty lines after access modifiers. MaxEmptyLinesToKeep is applied instead" },
            new FormatOptionSelectModelValue { Name = "ELAAMS_Always", Value = "Always", Description = "Always add empty line after access modifiers if there are none. MaxEmptyLinesToKeep is applied also" },
          },
          Input = "Leave"
        }
      },
      {
        "EmptyLineBeforeAccessModifier",
        new FormatOptionSelectModel {
          Version = CLangVersion(12),
          Name = "EmptyLineBeforeAccessModifier",
          Paramater = "EmptyLineBeforeAccessModifierStyle",
          Description = "Defines in which cases to put empty line before access modifiers.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ELBAMS_Never", Value = "Never", Description = "Remove all empty lines before access modifiers" },
            new FormatOptionSelectModelValue { Name = "ELBAMS_Leave", Value = "Leave", Description = "Keep existing empty lines before access modifiers" },
            new FormatOptionSelectModelValue { Name = "ELBAMS_LogicalBlock", Value = "LogicalBlock", Description = "Add empty line only when access modifier starts a new logical block" },
            new FormatOptionSelectModelValue { Name = "ELBAMS_Always", Value = "Always", Description = "Always add empty line before access modifiers unless access modifier is at the start of struct or class definition" }
          },
          Input = "Never"
        }
      },
      {
        "ExperimentalAutoDetectBinPacking",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "ExperimentalAutoDetectBinPacking",
          Paramater = "bool",
          Description = "If true, clang-format detects whether function calls and definitions are formatted with one parameter per line.\r\nEach call can be bin-packed, one-per-line or inconclusive. If it is inconclusive, e.g. completely on one line, but a decision needs to be made, clang-format analyzes whether there are other bin-packed cases in the input file and act accordingly.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "FixNamespaceComments",
        new FormatOptionToggleModel {
          Version = CLangVersion(5),
          Name = "FixNamespaceComments",
          Paramater = "bool",
          Description = "If \"true\", clang-format adds missing namespace end comments and fixes invalid existing ones.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "ForEachMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(3, 7),
          Name = "ForEachMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros that should be interpreted as foreach loops instead of as function calls.",
          MultipleInput = "- foreach\r\n- Q_FOREACH\r\n- BOOST_FOREACH"
        }
      },
      {
        "IfMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(13),
          Name = "IfMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros that should be interpreted as conditionals instead of as function calls.",
          MultipleInput = ""
        }
      },
      {
        "IncludeBlocks",
        new FormatOptionSelectModel {
          Version = CLangVersion(6),
          Name = "IncludeBlocks",
          Paramater = "IncludeBlocksStyle",
          Description = "Dependent on the value, multiple #include blocks can be sorted as one and divided based on category.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "IBS_Preserve", Value = "Preserve", Description = "Sort each #include block separately" },
            new FormatOptionSelectModelValue { Name = "IBS_Merge", Value = "Merge", Description = "Merge multiple #include blocks together and sort as one" },
            new FormatOptionSelectModelValue { Name = "IBS_Regroup", Value = "Regroup", Description = "Merge multiple #include blocks together and sort as one. Then split into groups based on category priority. See IncludeCategories" }
          },
          Input = "Preserve"
        }
      },
      {
        "IncludeCategories",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(3, 8),
          Name = "IncludeCategories",
          Paramater = "std::vector<std::string>",
          Description = "Regular expressions denoting the different #include categories used for ordering #includes.",
          MultipleInput = "- Regex: \'^\"(llvm|llvm-c|clang|clang-c)/'\r\n  Priority: 2\r\n  SortPriority: 0\r\n  CaseSensitive: false\r\n- Regex: '^(<|\"(gtest|gmock|isl|json)/)'\r\n  Priority: 3\r\n  SortPriority: 0\r\n  CaseSensitive: false\r\n- Regex: '.*'\r\n  Priority: 1\r\n  SortPriority: 0\r\n  CaseSensitive: false\r\n"
        }
      },
      {
        "IncludeIsMainRegex",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 9),
          Name = "IncludeIsMainRegex",
          Paramater = "std::string",
          Description = "Specify a regular expression of suffixes that are allowed in the file-to-main-include mapping.\r\nWhen guessing whether a #include is the “main” include (to assign category 0, see above), use this regex of allowed suffixes to the header stem. A partial match is done, so that: - “” means “arbitrary suffix” - “$” means “no suffix”\r\nFor example, if configured to “(_test)?$”, then a header a.h would be seen as the “main” include in both a.cc and a_test.cc.",
          Input = "'(Test)?$'"
        }
      },
      {
        "IncludeIsMainSourceRegex",
        new FormatOptionInputModel {
          Version = CLangVersion(10),
          Name = "IncludeIsMainSourceRegex",
          Paramater = "std::string",
          Description = "Specify a regular expression for files being formatted that are allowed to be considered “main” in the file-to-main-include mapping.\r\nBy default, clang-format considers files as “main” only when they end with: .c, .cc, .cpp, .c++, .cxx, .m or .mm extensions. For these files a guessing of “main” include takes place (to assign category 0, see above). This config option allows for additional suffixes and extensions for files to be considered as “main”.",
          Input = "''"
        }
      },
      {
        "IndentAccessModifiers",
        new FormatOptionToggleModel {
          Version = CLangVersion(13),
          Name = "IndentAccessModifiers",
          Paramater = "bool",
          Description = "Specify whether access modifiers should have their own indentation level.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentCaseBlocks",
        new FormatOptionToggleModel {
          Version = CLangVersion(11),
          Name = "IndentCaseBlocks",
          Paramater = "bool",
          Description = "Indent case label blocks one level from the case label.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentCaseLabels",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 3),
          Name = "IndentCaseLabels",
          Paramater = "bool",
          Description = "Indent case labels one level from the switch statement.\r\nWhen false, use the same indentation level as for the switch statement. Switch statement body is always indented one level more than case labels.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentExternBlock",
        new FormatOptionSelectModel {
          Version = CLangVersion(11),
          Name = "IndentExternBlock",
          Paramater = "IndentExternBlockStyle",
          Description = "IndentExternBlockStyle is the type of indenting of extern blocks.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "IEBS_AfterExternBlock", Value = "AfterExternBlock", Description = "Backwards compatible with AfterExternBlock’s indenting" },
            new FormatOptionSelectModelValue { Name = "IEBS_NoIndent", Value = "NoIndent", Description = "Does not indent extern blocks" },
            new FormatOptionSelectModelValue { Name = "IEBS_Indent", Value = "Indent", Description = "Indents extern blocks" }
          },
          Input = "Indent"
        }
      },
      {
        "IndentGotoLabels",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Name = "IndentGotoLabels",
          Paramater = "bool",
          Description = "Indent goto labels",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentPPDirectives",
        new FormatOptionSelectModel {
          Version = CLangVersion(6),
          Name = "IndentPPDirectives",
          Paramater = "PPDirectiveIndentStyle",
          Description = "The preprocessor directive indenting style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "PPDIS_None", Value = "None", Description = "Does not indent any directives" },
            new FormatOptionSelectModelValue { Name = "PPDIS_AfterHash", Value = "AfterHash", Description = "Indents directives after the hash" },
            new FormatOptionSelectModelValue { Name = "PPDIS_BeforeHash", Value = "BeforeHash", Description = "Indents directives before the hash" }
          },
          Input = "None"
        }
      },
      {
        "IndentRequires",
        new FormatOptionToggleModel {
          Version = CLangVersion(12),
          Deprecated = CLangVersion(15),
          Name = "IndentRequires",
          Paramater = "bool",
          Description = "Indent the requires clause in a template",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentRequiresClause",
        new FormatOptionToggleModel {
          Version = CLangVersion(15),
          Name = "IndentRequires",
          Paramater = "bool",
          Description = "Indent the requires clause in a template. This only applies when RequiresClausePosition is OwnLine, or WithFollowing.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "IndentWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "IndentWidth",
          Paramater = "unsigned",
          Description = "The number of columns to use for indentation.",
          Input = "2"
        }
      },
      {
        "IndentWrappedFunctionNames",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "IndentWrappedFunctionNames",
          Paramater = "bool",
          Description = "Indent if a function definition or declaration is wrapped after the type.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "InsertBraces",
        new FormatOptionToggleModel {
          Version = CLangVersion(15),
          Name = "InsertBraces",
          Paramater = "bool",
          Description = "Insert braces after control statements (if, else, for, do, and while) in C++ unless the control statements are inside macro definitions or the braces would enclose preprocessor directives.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "InsertNewlineAtEOF",
        new FormatOptionToggleModel {
          Version = CLangVersion(16),
          Name = "InsertNewlineAtEOF",
          Paramater = "bool",
          Description = "Insert a newline at end of file if missing.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "InsertTrailingCommas",
        new FormatOptionSelectModel {
          Version = CLangVersion(11),
          Name = "InsertTrailingCommas",
          Paramater = "TrailingCommaStyle",
          Description = "If set to TCS_Wrapped will insert trailing commas in container literals (arrays and objects) that wrap across multiple lines. It is currently only available for JavaScript and disabled by default TCS_None. InsertTrailingCommas cannot be used together with BinPackArguments as inserting the comma disables bin-packing.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "TCS_None", Value = "None", Description = "Do not insert trailing commas" },
            new FormatOptionSelectModelValue { Name = "TCS_Wrapped", Value = "Wrapped", Description = "Insert trailing commas in container literals that were wrapped over multiple lines. Note that this is conceptually incompatible with bin-packing, because the trailing comma is used as an indicator that a container should be formatted one-per-line (i.e. not bin-packed). So inserting a trailing comma counteracts bin-packing" }
          },
          Input = "None"
        }
      },
      /*
      {
        "IntegerLiteralSeparator",
        new FormatOptionSelectModel {
          Version = CLangVersion(13),
          Name = "IntegerLiteralSeparator",
          Paramater = "IntegerLiteralSeparatorStyle",
          Description = "Defines when to put an empty line after access modifiers. EmptyLineBeforeAccessModifier configuration handles the number of empty lines between two access modifiers.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "ELAAMS_Never", Value = "Never", Description = "Remove all empty lines after access modifiers" },
            new FormatOptionSelectModelValue { Name = "ELAAMS_Leave", Value = "Leave", Description = "Keep existing empty lines after access modifiers. MaxEmptyLinesToKeep is applied instead" },
            new FormatOptionSelectModelValue { Name = "ELAAMS_Always", Value = "Always", Description = "Always add empty line after access modifiers if there are none. MaxEmptyLinesToKeep is applied also" },
          },
          Input = "Leave"
        }
      },
      */
      {
        "JavaImportGroups",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(8),
          Name = "JavaImportGroups",
          Paramater = "std::vector<std::string>",
          Description = "A vector of prefixes ordered by the desired groups for Java imports.\r\nOne group’s prefix can be a subset of another - the longest prefix is always matched. Within a group, the imports are ordered lexicographically. Static imports are grouped separately and follow the same group rules. By default, static imports are placed before non-static imports, but this behavior is changed by another option, SortJavaStaticImport.",
          MultipleInput = "['com.example', 'com', 'org']"
        }
      },
      {
        "JavaScriptQuotes",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 9),
          Name = "JavaScriptQuotes",
          Paramater = "JavaScriptQuoteStyle",
          Description = "The JavaScriptQuoteStyle to use for JavaScript strings.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "JSQS_Leave", Value = "Leave", Description = "Leave string quotes as they are" },
            new FormatOptionSelectModelValue { Name = "JSQS_Single", Value = "Single", Description = "Always use single quotes" },
            new FormatOptionSelectModelValue { Name = "JSQS_Double", Value = "Double", Description = "Always use double quotes" },
          },
          Input = "Leave"
        }
      },
      {
        "JavaScriptWrapImports",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 9),
          Name = "JavaScriptWrapImports",
          Paramater = "bool",
          Description = "Whether to wrap JavaScript import/export statements",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "KeepEmptyLinesAtTheStartOfBlocks",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "KeepEmptyLinesAtTheStartOfBlocks",
          Paramater = "bool",
          Description = "If true, the empty line at the start of blocks is kept.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "LambdaBodyIndentation",
        new FormatOptionSelectModel {
          Version = CLangVersion(13),
          Name = "LambdaBodyIndentation",
          Paramater = "LambdaBodyIndentationKind",
          Description = "The indentation style of lambda bodies. Signature (the default) causes the lambda body to be indented one additional level relative to the indentation level of the signature. OuterScope forces the lambda body to be indented one additional level relative to the parent scope containing the lambda signature. For callback-heavy code, it may improve readability to have the signature indented two levels and to use OuterScope. The KJ style guide requires OuterScope.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "LBI_Signature", Value = "Signature", Description = "Align lambda body relative to the lambda signature" },
            new FormatOptionSelectModelValue { Name = "LBI_OuterScope", Value = "OuterScope", Description = "Align lambda body relative to the indentation level of the outer scope the lambda signature resides in" },
          },
          Input = "Signature"
        }
      },
      {
        "Language",
        new FormatOptionInputModel {
          Name = "Language",
          Paramater = "JavaScriptQuoteStyle",
          Description = "Language, this format style is targeted at.",
          Input = "Cpp"
        }
      },
      {
        "LineEnding",
        new FormatOptionSelectModel {
          Version = CLangVersion(16),
          Name = "LineEnding",
          Paramater = "LineEndingStyle",
          Description = "Line ending style (\\n or \\r\\n) to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "LE_LF", Value = "LF", Description = "Use \\n" },
            new FormatOptionSelectModelValue { Name = "LE_CRLF", Value = "CRLF", Description = "Use \\r\\n" },
            new FormatOptionSelectModelValue { Name = "LE_DeriveLF", Value = "DeriveLF", Description = "Use \\n unless the input has more lines ending in \\r\\n" },
            new FormatOptionSelectModelValue { Name = "LE_DeriveCRLF", Value = "DeriveCRLF", Description = "Use \\r\\n unless the input has more lines ending in \\n" },
          },
          Input = "DeriveCRLF"
        }
      },
      {
        "MacroBlockBegin",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "MacroBlockBegin",
          Paramater = "std::string",
          Description = "A regular expression matching macros that start a block.",
          Input = "''"
        }
      },
      {
        "MacroBlockEnd",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "MacroBlockEnd",
          Paramater = "std::string",
          Description = "A regular expression matching macros that end a block.",
          Input = "''"
        }
      },
      {
        "MaxEmptyLinesToKeep",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "MaxEmptyLinesToKeep",
          Paramater = "unsigned",
          Description = "The maximum number of consecutive empty lines to keep.",
          Input = "1"
        }
      },
      {
        "NamespaceIndentation",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "NamespaceIndentation",
          Paramater = "NamespaceIndentationKind",
          Description = "The indentation used for namespaces.\r\nPossible values:\r\n- NI_None (in configuration: None) Don’t indent in namespaces.\r\n- NI_Inner (in configuration: Inner) Indent only in inner namespaces (nested in other namespaces).\r\n- NI_All (in configuration: All) Indent in all namespaces.",
          Input = "None"
        }
      },
      {
        "NamespaceMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(9),
          Name = "NamespaceMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros which are used to open namespace blocks.",
          MultipleInput = ""
        }
      },
      {
        "ObjCBinPackProtocolList",
        new FormatOptionSelectModel {
          Version = CLangVersion(7),
          Name = "ObjCBinPackProtocolList",
          Paramater = "BinPackStyle",
          Description = "Controls bin-packing Objective-C protocol conformance list items into as few lines as possible when they go over ColumnLimit.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "BPS_Auto", Value = "Auto", Description = "Automatically determine parameter bin-packing behavior" },
            new FormatOptionSelectModelValue { Name = "BPS_Always", Value = "Always", Description = "Always bin-pack parameters" },
            new FormatOptionSelectModelValue { Name = "BPS_Never", Value = "Never", Description = "Never bin-pack parameters" }
          },
          Input = "Auto"
        }
      },
      {
        "ObjCBlockIndentWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "ObjCBlockIndentWidth",
          Paramater = "unsigned",
          Description = "The number of characters to use for indentation of ObjC blocks.",
          Input = "2"
        }
      },
      {
        "ObjCBreakBeforeNestedBlockParam",
        new FormatOptionToggleModel {
          Version = CLangVersion(11),
          Name = "ObjCBreakBeforeNestedBlockParam",
          Paramater = "bool",
          Description = "Break parameters list into lines when there is nested block parameters in a function call.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "ObjCSpaceAfterProperty",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "ObjCSpaceAfterProperty",
          Paramater = "bool",
          Description = "Add a space after @property in Objective-C, i.e. use @property (readonly) instead of @property(readonly)",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "ObjCSpaceBeforeProtocolList",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "ObjCSpaceBeforeProtocolList",
          Paramater = "bool",
          Description = "Add a space in front of an Objective-C protocol list, i.e. use Foo <Protocol> instead of Foo<Protocol>.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "PPIndentWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(13),
          Name = "PPIndentWidth",
          Paramater = "unsigned",
          Description = "The number of columns to use for indentation of preprocessor statements. When set to -1 (default) IndentWidth is used also for preprocessor statements.",
          Input = "-1"
        }
      },
      {
        "PackConstructorInitializers",
        new FormatOptionSelectModel {
          Version = CLangVersion(14),
          Name = "PackConstructorInitializers",
          Paramater = "PackConstructorInitializersStyle",
          Description = "The pack constructor initializers style to use.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "PCIS_Never", Value = "Never", Description = "Always put each constructor initializer on its own line" },
            new FormatOptionSelectModelValue { Name = "PCIS_BinPack", Value = "BinPack", Description = "Bin-pack constructor initializers" },
            new FormatOptionSelectModelValue { Name = "PCIS_CurrentLine", Value = "CurrentLine", Description = "Put all constructor initializers on the current line if they fit. Otherwise, put each one on its own line" },
            new FormatOptionSelectModelValue { Name = "PCIS_NextLine", Value = "NextLine", Description = "Same as PCIS_CurrentLine except that if all constructor initializers do not fit on the current line, try to fit them on the next line" },
          },
          Input = "Never"
        }
      },
      {
        "PenaltyBreakAssignment",
        new FormatOptionInputModel {
          Version = CLangVersion(5),
          Name = "PenaltyBreakAssignment",
          Paramater = "unsigned",
          Description = "The penalty for breaking around an assignment operator.",
          Input = "2"
        }
      },
      {
        "PenaltyBreakBeforeFirstCallParameter",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyBreakBeforeFirstCallParameter",
          Paramater = "unsigned",
          Description = "The penalty for breaking a function call after \"call(\".",
          Input = "19"
        }
      },
      {
        "PenaltyBreakComment",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyBreakComment",
          Paramater = "unsigned",
          Description = "The penalty for each line break introduced inside a comment.",
          Input = "300"
        }
      },
      {
        "PenaltyBreakFirstLessLess",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyBreakFirstLessLess",
          Paramater = "unsigned",
          Description = "The penalty for breaking before the first <<.",
          Input = "120"
        }
      },
      {
        "PenaltyBreakOpenParenthesis",
        new FormatOptionInputModel {
          Version = CLangVersion(14),
          Name = "PenaltyBreakOpenParenthesis",
          Paramater = "unsigned",
          Description = "The penalty for breaking after (.",
          Input = "120"
        }
      },
      {
        "PenaltyBreakString",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyBreakString",
          Paramater = "unsigned",
          Description = "The penalty for each line break introduced inside a string literal.",
          Input = "1000"
        }
      },
      {
        "PenaltyBreakTemplateDeclaration",
        new FormatOptionInputModel {
          Version = CLangVersion(7),
          Name = "PenaltyBreakTemplateDeclaration",
          Paramater = "unsigned",
          Description = "The penalty for breaking after template declaration.",
          Input = "10"
        }
      },
      {
        "PenaltyExcessCharacter",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyExcessCharacter",
          Paramater = "unsigned",
          Description = "The penalty for each character outside of the column limit.",
          Input = "1000000"
        }
      },
      {
        "PenaltyIndentedWhitespace",
        new FormatOptionInputModel {
          Version = CLangVersion(12),
          Name = "PenaltyIndentedWhitespace",
          Paramater = "unsigned",
          Description = "Penalty for each character of whitespace indentation (counted relative to leading non-whitespace column).",
          Input = "0"
        }
      },
      {
        "PenaltyReturnTypeOnItsOwnLine",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "PenaltyReturnTypeOnItsOwnLine",
          Paramater = "unsigned",
          Description = "Penalty for putting the return type of a function onto its own line.",
          Input = "60"
        }
      },
      {
        "PointerAlignment",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 7),
          Name = "PointerAlignment",
          Paramater = "PointerAlignmentStyle",
          Description = "Pointer and reference alignment style.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "PAS_Left", Value = "Left", Description = "Align pointer to the left" },
            new FormatOptionSelectModelValue { Name = "PAS_Right", Value = "Right", Description = "Align pointer to the right" },
            new FormatOptionSelectModelValue { Name = "PAS_Middle", Value = "Middle", Description = "Align pointer in the middle" }
          },
          Input = "Right"
        }
      },
      {
        "QualifierAlignment",
        new FormatOptionSelectModel {
          Version = CLangVersion(14),
          Name = "QualifierAlignment",
          Paramater = "QualifierAlignmentStyle",
          Description = "Different ways to arrange specifiers and qualifiers (e.g. const/volatile).",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "QAS_Leave", Value = "Leave", Description = "Don’t change specifiers/qualifiers to either Left or Right alignment" },
            new FormatOptionSelectModelValue { Name = "QAS_Left", Value = "Left", Description = "Change specifiers/qualifiers to be left-aligned" },
            new FormatOptionSelectModelValue { Name = "QAS_Right", Value = "Right", Description = "Change specifiers/qualifiers to be right-aligned" },
            new FormatOptionSelectModelValue { Name = "QAS_Custom", Value = "Custom", Description = "Change specifiers/qualifiers to be aligned based on QualifierOrder" },
          },
          Input = "Leave"
        }
      },
      {
        "QualifierOrder",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(14),
          Name = "QualifierOrder",
          Paramater = "std::vector<std::string>",
          Description = "The order in which the qualifiers appear. Order is an array that can contain any of the following: const, inline, static, friend, constexpr, volatile, restrict, type\r\n"
                      + "Note: it MUST contain ‘type’. Items to the left of ‘type’ will be placed to the left of the type and aligned in the order supplied. Items to the right of ‘type’ will be placed to the right of the type and aligned in the order supplied.",
          MultipleInput = ""
        }
      },
      {
        "RawStringFormats",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(6),
          Name = "RawStringFormats",
          Paramater = "std::vector<RawStringFormat>",
          Description = "Defines hints for detecting supported languages code blocks in raw strings.\r\nA raw string with a matching delimiter or a matching enclosing function name will be reformatted assuming the specified language based on the style for that language defined in the .clang-format file. If no style has been defined in the .clang-format file for the specific language, a predefined style given by ‘BasedOnStyle’ is used. If ‘BasedOnStyle’ is not found, the formatting is based on llvm style. A matching delimiter takes precedence over a matching enclosing function name for determining the language of the raw string contents.",
          MultipleInput = "- Language: Cpp\r\n  Delimiters:\r\n    - cc\r\n    - CC\r\n    - cpp\r\n    - Cpp\r\n    - CPP\r\n    - 'c++'\r\n    - 'C++'\r\n  CanonicalDelimiter: ''\r\n  BasedOnStyle: google\r\n- Language: TextProto\r\n  Delimiters:\r\n    - pb\r\n    - PB\r\n    - proto\r\n    - PROTO\r\n  EnclosingFunctions:\r\n    - EqualsProto\r\n    - EquivToProto\r\n    - PARSE_PARTIAL_TEXT_PROTO\r\n    - PARSE_TEST_PROTO\r\n    - PARSE_TEXT_PROTO\r\n    - ParseTextOrDie\r\n    - ParseTextProtoOrDie\r\n    - ParseTestProto\r\n    - ParsePartialTestProto\r\n  CanonicalDelimiter: ''\r\n  BasedOnStyle: google"
        }
      },
      {
        "ReferenceAlignment",
        new FormatOptionSelectModel {
          Version = CLangVersion(13),
          Name = "ReferenceAlignment",
          Paramater = "ReferenceAlignmentStyle",
          Description = "Reference alignment style (overrides PointerAlignment for references).",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "RAS_Pointer", Value = "Pointer", Description = "Align reference like PointerAlignment" },
            new FormatOptionSelectModelValue { Name = "RAS_Left", Value = "Left", Description = "Align reference to the left" },
            new FormatOptionSelectModelValue { Name = "RAS_Right", Value = "Right", Description = "Align reference to the right" },
            new FormatOptionSelectModelValue { Name = "RAS_Middle", Value = "Middle", Description = "Align reference in the middle" },
          },
          Input = "Pointer"
        }
      },
      {
        "ReflowComments",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 8),
          Name = "ReflowComments",
          Paramater = "bool",
          Description = "If \"true\", clang-format will attempt to re-flow comments.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "RemoveBracesLLVM",
        new FormatOptionToggleModel {
          Version = CLangVersion(14),
          Name = "RemoveBracesLLVM",
          Paramater = "bool",
          Description = "Remove optional braces of control statements (if, else, for, and while) in C++ according to the LLVM coding style.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "RemoveSemicolon",
        new FormatOptionToggleModel {
          Version = CLangVersion(16),
          Name = "RemoveSemicolon",
          Paramater = "bool",
          Description = "Remove semicolons after the closing brace of a non-empty function.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "RequiresClausePosition",
        new FormatOptionSelectModel {
          Version = CLangVersion(15),
          Name = "RequiresClausePosition",
          Paramater = "RequiresClausePositionStyle",
          Description = "The position of the requires clause.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "RCPS_OwnLine", Value = "OwnLine", Description = "Always put the requires clause on its own line" },
            new FormatOptionSelectModelValue { Name = "RCPS_WithPreceding", Value = "WithPreceding", Description = "Try to put the clause together with the preceding part of a declaration. For class templates: stick to the template declaration. For function templates: stick to the template declaration. For function declaration followed by a requires clause: stick to the parameter list" },
            new FormatOptionSelectModelValue { Name = "RCPS_WithFollowing", Value = "WithFollowing", Description = "Try to put the requires clause together with the class or function declaration" },
            new FormatOptionSelectModelValue { Name = "RCPS_SingleLine", Value = "SingleLine", Description = "Try to put everything in the same line if possible. Otherwise normal line breaking rules take over" },
          },
          Input = "OwnLine"
        }
      },
      {
        "RequiresExpressionIndentation",
        new FormatOptionSelectModel {
          Version = CLangVersion(16),
          Name = "RequiresExpressionIndentation",
          Paramater = "RequiresExpressionIndentationKind",
          Description = "The indentation used for requires expression bodies.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "REI_OuterScope", Value = "OuterScope", Description = "Align requires expression body relative to the indentation level of the outer scope the requires expression resides in" },
            new FormatOptionSelectModelValue { Name = "REI_Keyword", Value = "Keyword", Description = "Align requires expression body relative to the requires keyword" },
          },
          Input = "OuterScope"
        }
      },
      {
        "SeparateDefinitionBlocks",
        new FormatOptionSelectModel {
          Version = CLangVersion(14),
          Name = "SeparateDefinitionBlocks",
          Paramater = "SeparateDefinitionStyle",
          Description = "Specifies the use of empty lines to separate definition blocks, including classes, structs, enums, and functions.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SDS_Leave", Value = "Leave", Description = "Leave definition blocks as they are" },
            new FormatOptionSelectModelValue { Name = "SDS_Always", Value = "Always", Description = "Insert an empty line between definition blocks" },
            new FormatOptionSelectModelValue { Name = "SDS_Never", Value = "Never", Description = "Remove any empty line between definition blocks" },
          },
          Input = "Leave"
        }
      },
      {
        "ShortNamespaceLines",
        new FormatOptionInputModel {
          Version = CLangVersion(13),
          Name = "ShortNamespaceLines",
          Paramater = "unsigned",
          Description = "The maximal number of unwrapped lines that a short namespace spans.\r\n"
                      + "This determines the maximum length of short namespaces by counting unwrapped lines (i.e. containing neither opening nor closing namespace brace) and makes “FixNamespaceComments” omit adding end comments for those.",
          Input = "1"
        }
      },
      {
        "SortIncludes",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 8),
          Name = "SortIncludes",
          Paramater = "bool",
          Description = "If \"true\", clang-format will sort #includes.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SortJavaStaticImport",
        new FormatOptionInputModel {
          Version = CLangVersion(12),
          Name = "SortJavaStaticImport",
          Paramater = "SortJavaStaticImportOptions",
          Description = "When sorting Java imports, by default static imports are placed before non-static imports. If JavaStaticImportAfterImport is After, static imports are placed after non-static imports.\r\nPossible values:\r\n- SJSIO_Before (in configuration: Before) Static imports are placed before non-static imports.\r\n- SJSIO_After (in configuration: After) Static imports are placed after non-static imports.",
          Input = "Before"
        }
      },
      {
        "SortUsingDeclarations",
        new FormatOptionToggleModel {
          Version = CLangVersion(5),
          Name = "SortUsingDeclarations",
          Paramater = "bool",
          Description = "If \"true\", clang-format will sort using declarations.\r\nThe order of using declarations is defined as follows: Split the strings by “::” and discard any initial empty strings. The last element of each list is a non-namespace name; all others are namespace names. Sort the lists of names lexicographically, where the sort order of individual names is that all non-namespace names come before all namespace names, and within those groups, names are in case-insensitive lexicographic order.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceAfterCStyleCast",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 5),
          Name = "SpaceAfterCStyleCast",
          Paramater = "bool",
          Description = "If \"true\", a space is inserted after C style casts.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpaceAfterLogicalNot",
        new FormatOptionToggleModel {
          Version = CLangVersion(9),
          Name = "SpaceAfterLogicalNot",
          Paramater = "bool",
          Description = "If \"true\", a space is inserted after the logical not operator (!).",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpaceAfterTemplateKeyword",
        new FormatOptionToggleModel {
          Version = CLangVersion(4),
          Name = "SpaceAfterTemplateKeyword",
          Paramater = "bool",
          Description = "If \"true\", a space will be inserted after the ‘template’ keyword.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceAroundPointerQualifiers",
        new FormatOptionSelectModel {
          Version = CLangVersion(12),
          Name = "SpaceAroundPointerQualifiers",
          Paramater = "SpaceAroundPointerQualifiersStyle",
          Description = "Defines in which cases to put a space before or after pointer qualifiers.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "SAPQ_Default", Value = "Default", Description = "Don’t ensure spaces around pointer qualifiers and use PointerAlignment instead" },
            new FormatOptionSelectModelValue { Name = "SAPQ_Before", Value = "Before", Description = "Ensure that there is a space before pointer qualifiers" },
            new FormatOptionSelectModelValue { Name = "SAPQ_After", Value = "After", Description = "Ensure that there is a space after pointer qualifiers" },
            new FormatOptionSelectModelValue { Name = "SAPQ_Both", Value = "Both", Description = "Ensure that there is a space both before and after pointer qualifiers" }
          },
          Input = "Default"
        }
      },
      {
        "SpaceBeforeAssignmentOperators",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpaceBeforeAssignmentOperators",
          Paramater = "bool",
          Description = "If \"false\", spaces will be removed before assignment operators.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceBeforeCaseColon",
        new FormatOptionToggleModel {
          Version = CLangVersion(12),
          Name = "SpaceBeforeCaseColon",
          Paramater = "bool",
          Description = "If \"false\", spaces will be removed before case colon.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceBeforeCpp11BracedList",
        new FormatOptionToggleModel {
          Version = CLangVersion(7),
          Name = "SpaceBeforeCpp11BracedList",
          Paramater = "bool",
          Description = "If \"true\", a space will be inserted before a C++11 braced list used to initialize an object (after the preceding identifier or type)..",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpaceBeforeCtorInitializerColon",
        new FormatOptionToggleModel {
          Version = CLangVersion(7),
          Name = "SpaceBeforeCtorInitializerColon",
          Paramater = "bool",
          Description = "If \"false\", spaces will be removed before constructor initializer colon.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceBeforeInheritanceColon",
        new FormatOptionToggleModel {
          Version = CLangVersion(7),
          Name = "SpaceBeforeInheritanceColon",
          Paramater = "bool",
          Description = "If \"false\", spaces will be removed before inheritance colon.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceBeforeParens",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 5),
          Name = "SpaceBeforeParens",
          Paramater = "SpaceBeforeParensOptions",
          Description = "Defines in which cases to put a space before opening parentheses.\r\nPossible values:\r\n- SBPO_Never (in configuration: Never) Never put a space before opening parentheses.\r\n- SBPO_ControlStatements (in configuration: ControlStatements) Put a space before opening parentheses only after control statement keywords (for/if/while...).\r\n- SBPO_Always (in configuration: Always) Always put a space before opening parentheses, except when it’s prohibited by the syntax rules (in function-like macro definitions) or when determined by other style rules (after unary operators, opening parentheses, etc.)",
          Input = "ControlStatements"
        }
      },
      {
        "SpaceBeforeParensOptions",
        new FormatOptionMultipleToggleModel {
          Version = CLangVersion(14),
          Name = "SpaceBeforeParensOptions",
          Paramater = "SpaceBeforeParensCustom",
          Description = "Control of individual space before parentheses.\r\n"
                      + "If SpaceBeforeParens is set to Custom, use this to specify how each individual space before parentheses case should be handled. Otherwise, this is ignored.",
          ToggleFlags = new List<ToggleModel>() {
            new ToggleModel("AfterControlStatements", ToggleValues.False),
            new ToggleModel("AfterForeachMacros", ToggleValues.False),
            new ToggleModel("AfterFunctionDeclarationName", ToggleValues.False),
            new ToggleModel("AfterFunctionDefinitionName", ToggleValues.False),
            new ToggleModel("AfterIfMacros", ToggleValues.False),
            new ToggleModel("AfterOverloadedOperator", ToggleValues.False),
            new ToggleModel("AfterRequiresInClause", ToggleValues.False),
            new ToggleModel("AfterRequiresInExpression", ToggleValues.False),
            new ToggleModel("BeforeNonEmptyParentheses", ToggleValues.False)
          }
        }
      },
      {
        "SpaceBeforeRangeBasedForLoopColon",
        new FormatOptionToggleModel {
          Version = CLangVersion(7),
          Name = "SpaceBeforeRangeBasedForLoopColon",
          Paramater = "bool",
          Description = "If \"false\", spaces will be removed before range-based for loop colon.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceBeforeSquareBrackets",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Name = "SpaceBeforeSquareBrackets",
          Paramater = "bool",
          Description = "If \"true\", spaces will be before [. Lambdas will not be affected. Only the first [ will get a space added.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceInEmptyBlock",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Name = "SpaceInEmptyBlock",
          Paramater = "bool",
          Description = "If \"true\", spaces will be inserted into {}.",
          BooleanCombobox = ToggleValues.True
        }
      },
      {
        "SpaceInEmptyParentheses",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpaceInEmptyParentheses",
          Paramater = "bool",
          Description = "If \"true\", spaces may be inserted into ().",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpacesBeforeTrailingComments",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "SpacesBeforeTrailingComments",
          Paramater = "unsigned",
          Description = "The number of spaces to before trailing line comments.",
          Input = "1"
        }
      },
      {
        "SpacesInAngles",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 4),
          Name = "SpacesInAngles",
          Paramater = "bool",
          Description = "If true, spaces will be inserted after \"<\" and before \">\" in template argument lists",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpacesInCStyleCastParentheses",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpacesInCStyleCastParentheses",
          Paramater = "bool",
          Description = "If true, spaces may be inserted into C style casts.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpacesInConditionalStatement",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Name = "SpacesInConditionalStatement",
          Paramater = "bool",
          Description = "If true, spaces will be inserted around if/for/switch/while conditions.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpacesInContainerLiterals",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpacesInContainerLiterals",
          Paramater = "bool",
          Description = "If true, spaces are inserted inside container literals (e.g. ObjC and JavaScript array and dict literals).",
          BooleanCombobox = ToggleValues.True
        }
      },
      /*
      {
        "SpacesInLineCommentPrefix",
        new FormatOptionInputModel {
          Version = CLangVersion(13),
          Name = "SpacesInLineCommentPrefix",
          Paramater = "unsigned",
          Description = "How many spaces are allowed at the start of a line comment. To disable the maximum set it to -1, apart from that the maximum takes precedence over the minimum.",
          Input = "1"
        }
      },
      */
      {
        "SpacesInParentheses",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpacesInParentheses",
          Paramater = "bool",
          Description = "If \"true\", spaces will be inserted after ‘(‘ and before ‘)’.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "SpacesInSquareBrackets",
        new FormatOptionToggleModel {
          Version = CLangVersion(3, 7),
          Name = "SpacesInSquareBrackets",
          Paramater = "bool",
          Description = "If \"true\", spaces will be inserted after [ and before ]. Lambdas without arguments or unspecified size array declarations will not be affected.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "Standard",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "Standard",
          Paramater = "LanguageStandard",
          Description = "Parse and format C++ constructs compatible with this standard.\r\nPossible values:\r\n- LS_Cpp03 (in configuration: c++03) Parse and format as C++03. Cpp03 is a deprecated alias for c++03\r\n- LS_Cpp11 (in configuration: c++11) Parse and format as C++11.\r\n- LS_Cpp14 (in configuration: c++14) Parse and format as C++14.\r\n- LS_Cpp17 (in configuration: c++17) Parse and format as C++17.\r\n- LS_Cpp20 (in configuration: c++20) Parse and format as C++20.\r\n- LS_Latest (in configuration: Latest) Parse and format using the latest supported language version. Cpp11 is a deprecated alias for Latest",
          Input = "Cpp11"
        }
      },
      {
        "StatementAttributeLikeMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(12),
          Name = "StatementAttributeLikeMacros",
          Paramater = "std::vector<std::string>",
          Description = "Macros which are ignored in front of a statement, as if they were an attribute. So that they are not parsed as identifier, for example for Qts emit.",
          MultipleInput = "- Q_UNUSED\r\n- QT_REQUIRE_VERSION"
        }
      },
      {
        "StatementMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(8),
          Name = "StatementMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros that should be interpreted as complete statements. \r\nTypical macros are expressions, and require a semi-colon to be added; sometimes this is not the case, and this allows to make clang-format aware of such cases.",
          MultipleInput = "- Q_UNUSED\r\n- QT_REQUIRE_VERSION"
        }
      },
      {
        "TabWidth",
        new FormatOptionInputModel {
          Version = CLangVersion(3, 7),
          Name = "TabWidth",
          Paramater = "unsigned",
          Description = "The number of columns used for tab stops.",
          Input = "8"
        }
      },
      {
        "TypenameMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(9),
          Name = "TypenameMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros that should be interpreted as type declarations instead of as function calls.",
          MultipleInput = "['STACK_OF', 'LIST']"
        }
      },
      {
        "UseCRLF",
        new FormatOptionToggleModel {
          Version = CLangVersion(10),
          Deprecated = CLangVersion(16),
          Name = "UseCRLF",
          Paramater = "bool",
          Description = "Use \\r\\n instead of \\n for line breaks. Also used as fallback if DeriveLineEnding is true.",
          BooleanCombobox = ToggleValues.False
        }
      },
      {
        "UseTab",
        new FormatOptionSelectModel {
          Version = CLangVersion(3, 7),
          Name = "UseTab",
          Paramater = "UseTabStyle",
          Description = "The way to use tab characters in the resulting file.",
          Values = new[] {
            new FormatOptionSelectModelValue { Name = "UT_Never", Value = "Never", Description = "Never use tab" },
            new FormatOptionSelectModelValue { Name = "UT_ForIndentation", Value = "ForIndentation", Description = "Use tabs only for indentation" },
            new FormatOptionSelectModelValue { Name = "UT_ForContinuationAndIndentation", Value = "ForContinuationAndIndentation", Description = "Use tabs only for line continuation and indentation" },
            new FormatOptionSelectModelValue { Name = "UT_Always", Value = "Always", Description = "Use tabs whenever we need to fill whitespace that spans at least from one tab stop to the next on" }
          },
          Input = "Never"
        }
      },
      {
        "WhitespaceSensitiveMacros",
        new FormatOptionMultipleInputModel {
          Version = CLangVersion(11),
          Name = "WhitespaceSensitiveMacros",
          Paramater = "std::vector<std::string>",
          Description = "A vector of macros which are whitespace-sensitive and should not be touched.",
          MultipleInput = "- STRINGIZE\r\n- PP_STRINGIZE\r\n- BOOST_PP_STRINGIZE\r\n- NS_SWIFT_NAME\r\n- CF_SWIFT_NAME"
        }
      }
    };

    public void DisableAllOptions()
    {
      foreach (var item in FormatOptions.Values)
      {
        item.IsEnabled = false;
      }
    }

    public List<IFormatOption> GetFormatOptionsValues()
    {
      return FormatOptions.Values.ToList();
    }
  }
}
