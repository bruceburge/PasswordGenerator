﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    /// <summary>
    /// Parts of speech codes used to the classification of a word
    /// See: http://ucrel.lancs.ac.uk/claws7tags.html
    /// </summary>
    enum PartsOfSpeech
    {
        APPGE,
        AT,
        AT1,
        BCL,
        CC,
        CCB,
        CS,
        CSA,
        CSN,
        CST,
        CSW,
        DA,
        DA1,
        DA2,
        DAR,
        DAT,
        DB,
        DB2,
        DD,
        DD1,
        DD2,
        DDQ,
        DDQGE,
        DDQV,
        EX,
        FO,
        FU,
        FW,
        GE,
        IF,
        II,
        IO,
        IW,
        JJ,
        JJR,
        JJT,
        JK,
        MC,
        MC1,
        MC2,
        MCGE,
        MCMC,
        MD,
        MF,
        ND1,
        NN,
        NN1,
        NN2,
        NNA,
        NNB,
        NNL1,
        NNL2,
        NNO,
        NNO2,
        NNT1,
        NNT2,
        NNU,
        NNU1,
        NNU2,
        NP,
        NP1,
        NP2,
        NPD1,
        NPD2,
        NPM1,
        NPM2,
        PN,
        PN1,
        PNQO,
        PNQS,
        PNQV,
        PNX1,
        PPGE,
        PPH1,
        PPHO1,
        PPHO2,
        PPHS1,
        PPHS2,
        PPIO1,
        PPIO2,
        PPIS1,
        PPIS2,
        PPX1,
        PPX2,
        PPY,
        RA,
        REX,
        RG,
        RGQ,
        RGQV,
        RGR,
        RGT,
        RL,
        RP,
        RPK,
        RR,
        RRQ,
        RRQV,
        RRR,
        RRT,
        RT,
        TO,
        UH,
        VB0,
        VBDR,
        VBDZ,
        VBG,
        VBI,
        VBM,
        VBN,
        VBR,
        VBZ,
        VD0,
        VDD,
        VDG,
        VDI,
        VDN,
        VDZ,
        VH0,
        VHD,
        VHG,
        VHI,
        VHN,
        VHZ,
        VM,
        VMK,
        VV0,
        VVD,
        VVG,
        VVGK,
        VVI,
        VVN,
        VVNK,
        VVZ,
        XX,
        ZZ1,
        ZZ2,
        None = 0
    }
}
