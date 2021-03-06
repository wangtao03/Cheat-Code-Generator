// For Keystone Engine. AUTO-GENERATED FILE, DO NOT EDIT [keystoneConstants.cs]
namespace Keystone
{
    public enum Architecture : int
    {
        ARM = 1,
        ARM64 = 2,
        MIPS = 3,
        X86 = 4,
        PPC = 5,
        SPARC = 6,
        SYSTEMZ = 7,
        HEXAGON = 8,
        MAX = 9,
    }

    public enum Mode : uint
    {
        LITTLE_ENDIAN = 0u,
        BIG_ENDIAN = 0x40000000,
        ARM = 1u,
        THUMB = 0x10,
        V8 = 0x40,
        MICRO = 0x10,
        MIPS3 = 0x20,
        MIPS32R6 = 0x40,
        MIPS32 = 4u,
        MIPS64 = 8u,
        X16 = 2u,
        X32 = 4u,
        X64 = 8u,
        PPC32 = 4u,
        PPC64 = 8u,
        QPX = 0x10,
        SPARC32 = 4u,
        SPARC64 = 8u,
        V9 = 0x10
    }

    public enum KeystoneError : short
    {
        KS_ERR_ASM = 128,
        KS_ERR_ASM_ARCH = 512,
        KS_ERR_OK = 0,
        KS_ERR_NOMEM = 1,
        KS_ERR_ARCH = 2,
        KS_ERR_HANDLE = 3,
        KS_ERR_MODE = 4,
        KS_ERR_VERSION = 5,
        KS_ERR_OPT_INVALID = 6,
        KS_ERR_ASM_EXPR_TOKEN = 128,
        KS_ERR_ASM_DIRECTIVE_VALUE_RANGE = 129,
        KS_ERR_ASM_DIRECTIVE_ID = 130,
        KS_ERR_ASM_DIRECTIVE_TOKEN = 131,
        KS_ERR_ASM_DIRECTIVE_STR = 132,
        KS_ERR_ASM_DIRECTIVE_COMMA = 133,
        KS_ERR_ASM_DIRECTIVE_RELOC_NAME = 134,
        KS_ERR_ASM_DIRECTIVE_RELOC_TOKEN = 135,
        KS_ERR_ASM_DIRECTIVE_FPOINT = 136,
        KS_ERR_ASM_DIRECTIVE_UNKNOWN = 137,
        KS_ERR_ASM_DIRECTIVE_EQU = 138,
        KS_ERR_ASM_DIRECTIVE_INVALID = 139,
        KS_ERR_ASM_VARIANT_INVALID = 140,
        KS_ERR_ASM_EXPR_BRACKET = 141,
        KS_ERR_ASM_SYMBOL_MODIFIER = 142,
        KS_ERR_ASM_SYMBOL_REDEFINED = 143,
        KS_ERR_ASM_SYMBOL_MISSING = 144,
        KS_ERR_ASM_RPAREN = 145,
        KS_ERR_ASM_STAT_TOKEN = 146,
        KS_ERR_ASM_UNSUPPORTED = 147,
        KS_ERR_ASM_MACRO_TOKEN = 148,
        KS_ERR_ASM_MACRO_PAREN = 149,
        KS_ERR_ASM_MACRO_EQU = 150,
        KS_ERR_ASM_MACRO_ARGS = 151,
        KS_ERR_ASM_MACRO_LEVELS_EXCEED = 152,
        KS_ERR_ASM_MACRO_STR = 153,
        KS_ERR_ASM_MACRO_INVALID = 154,
        KS_ERR_ASM_ESC_BACKSLASH = 155,
        KS_ERR_ASM_ESC_OCTAL = 156,
        KS_ERR_ASM_ESC_SEQUENCE = 157,
        KS_ERR_ASM_ESC_STR = 158,
        KS_ERR_ASM_TOKEN_INVALID = 159,
        KS_ERR_ASM_INSN_UNSUPPORTED = 160,
        KS_ERR_ASM_FIXUP_INVALID = 161,
        KS_ERR_ASM_LABEL_INVALID = 162,
        KS_ERR_ASM_FRAGMENT_INVALID = 163,
        KS_ERR_ASM_INVALIDOPERAND = 512,
        KS_ERR_ASM_MISSINGFEATURE = 513,
        KS_ERR_ASM_MNEMONICFAIL = 514
    }

    public enum OptionType : int
    {
        SYNTAX = 1,
        SYM_RESOLVER = 2,
    }

    public enum OptionValue : short
    {
        SYNTAX_INTEL = 1,
        SYNTAX_ATT = 2,
        SYNTAX_NASM = 4,
        SYNTAX_MASM = 8,
        SYNTAX_GAS = 16,
        SYNTAX_RADIX16 = 32
    }
}