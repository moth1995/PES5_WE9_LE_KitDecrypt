using System;
using System.IO;

namespace PES5_WE9_LE_KitDecrypt
{
    public class KitDecrypt
    {
        private static uint[] keys0 = new uint[]
{
                0xb506bd9c,
                0xec556da8,
                0xd16b02fb,
                0xdd57b24f,
                0xf26f25c0,
                0x673211b9,
                0xa37304ad,
                0x3a554960,
                0x79eaddc0,
                0xe6a29cd3,
                0xc176ce36,
                0xc251c865,
                0x62419d21,
                0x59ff456d,
                0x7750f600,
                0x56559e77,
                0xc3ae76ea,
};
        private static uint[] keys1 = new uint[]
        {
                0x1f20659a,
                0x3da89392,
                0x3b54aa5c,
                0x66bcda9a,
                0xab451999,
                0x6f6e6ae7,
                0x7cceb863,
                0xd166cc54,
                0x4df13b7,
                0x8bea0cfb,
                0x580f218d,
                0xb42ab75c,
                0xa0192072,
                0x644bb80a,
                0xbbd1dbcc,
                0x98b00186,
                0x2f92df9e,
                0x55bd2924,
                0x49fd5559,
                0x469d4bea,
                0x7861518d,
                0xf04be1a7,
                0x3fa84371,
                0x2ee80710,
                0x60289970,
                0xe0289d53,
                0x9afb0fdc,
                0x3c392984,
                0x51e5a6ba,
                0x993ed10d,
                0x1133b040,
                0x91ec5aef,
                0x1b0e4d92,
                0xc99a5bd7,
                0x5dcc7995,
                0xeebe04bb,
                0xc3077cb4,
                0x52bd7007,
                0xf3f22aa4,
                0x33646562,
                0xd7720d4b,
                0x6fc989a3,
                0xd2f81eba,
                0x697fe59e,
                0xe35843b1,
                0x64f6895f,
                0x33f93b3e,
                0x7c7165c7,
                0x76ea5acc,
                0xea4a37e2,
                0xd5849f81,
                0x4b77b8a,
                0x9ae52a87,
                0x28a760,
                0xd1f4d7f0,
                0x409d7102,
                0xbd86bcaa,
                0x70c061fa,
                0x67716d27,
                0x54b52d0b,
                0x176b0e40,
                0xbfa5c97a,
                0x7ec8954e,
                0x44e2cf90,
                0x9ba2399f,
                0x3eda1468,
                0xc1ae5dc4,
                0xcd78a185,
                0x5ab1b8bd,
                0xc1f8fc91,
                0x87075782,
                0x668376e,
                0xd2b6642c,
                0x9d647e99,
                0xfef57d3b,
                0xfcf660c5,
                0xd5200a58,
                0xe892a8f2,
                0xce852246,
                0xc8c65fb5,
                0x9ee8acb,
                0x9311fa78,
                0x10230e07,
                0xc92a37d8,
                0xfe7b114f,
                0xe7f2bf5f,
                0x72a7ce67,
                0x2ea915b6,
                0x8047b8f2,
                0xedc71466,
                0x62b5dfdb,
                0x6c7efb1d,
                0xeeddc8d1,
                0xcb9d8b35,
                0xf91cbd51,
                0x1ed5ec2c,
                0x604478a7,
                0xc0dfe8e3,
                0xf4057857,
                0x8c0e8750,
                0x64602832,
                0x31a3b8e5,
                0x9eb8f882,
                0x96d042a2,
                0x960761a8,
                0x3a6a0031,
                0x75878a9e,
                0x90f2064d,
                0x9637f022,
                0x709165a,
                0x32f2b46f,
                0x6e7db8de,
                0x6c4bbc95,
                0x77f6f56f,
                0x5169225,
                0x704378eb,
                0x5dbb51d6,
                0xb753c154,
                0xc1d788d7,
                0x5482594,
                0x9482ddd1,
                0x426a2453,
                0x3bd21679,
                0x67cae58,
                0x5d32b129,
                0xf6852a62,
                0x5ea9a375,
                0x7a7054a8,
                0xb1c7420,
                0xcf5ee8d5,
                0xa4f2467c,
                0x643f652b,
                0xe496313a,
                0x1e264543,
                0x75b2a00,
                0x7d6bd11b,
                0x7f77878d,
                0x6fd65221,
                0x4897b584,
                0x911d2815,
                0x79c7742a,
                0x95c8ac08,
                0xdef1cf95,
                0xd6af36a8,
                0xc3a22d2e,
                0xd4101c2a,
                0x478ab5b3,
                0xdedc82ec,
                0x694b1158,
                0x3a43169e,
                0x98437eea,
                0xfa83eb32,
                0x68679816,
                0xe2346626,
                0xc95ee9a2,
                0x86958180,
                0xd805eb73,
                0x5b20883e,
                0xe38365e5,
                0xa08fb08,
                0x70e47d43,
                0xf78ee135,
                0x6fdb5606,
                0xfffbcf66,
                0xc6f1651f,
                0x5fe605f8,
                0x23eec3a4,
                0xa0734247,
                0xd5e22105,
                0xa99ca4a6,
                0x967ac4b7,
                0x666c2683,
                0xfe8e54d4,
                0xf439b6b9,
                0x68b3da59,
                0x2d60c879,
                0xda4c21a9,
                0x1add7f8d,
                0x3945ed05,
                0x8b566514,
                0xf4fd340a,
                0x2c07442b,
                0xea596d3,
                0x84f1e7a4,
                0x6a336a57,
                0x82b50c8d,
                0x2c9f0aba,
                0x96ad4ba8,
                0x3ba18fe1,
                0x7c6ad250,
                0x10d9b340,
                0xfbe322cc,
                0xc0f58d8e,
                0xd42998c,
                0x4b1b7f3a,
                0x70bb2584,
                0xf138d5dd,
                0x21740780,
                0xae2d4c90,
                0x2240c06d,
                0x5c800b88,
                0x615c0ee2,
                0x2a19eb1f,
                0xba14ca9,
                0x914c7516,
                0xe53439dc,
                0x78ed4521,
                0xb74f62a,
                0x83d3acde,
                0x6e7994ca,
                0x792393f0,
                0xa88d845c,
                0x9b7009cd,
                0x89f6bf70,
                0x68c537b4,
                0x1bc8a547,
                0x843a0553,
                0x7a4ab8e9,
                0x9e2fc95,
                0xd918b36,
                0x5f974d12,
                0xdb46e41,
                0xffb0fe35,
                0x9d04040e,
                0x85f258f6,
                0x23a79f7d,
                0x9304933a,
                0x3b44ac56,
                0x261d074f,
                0x2e925762,
                0x2b87dc35,
                0x1af855ad,
                0x8343526c,
                0x333e7f86,
                0x9385aa8c,
                0xe9fa1eee,
                0x2ab6f0dc,
                0xa75eb26d,
                0x119ec5b,
                0x889903d2,
                0xbd2f31fb,
                0x2909c865,
                0xf6a88145,
                0x9b9ce8fc,
                0xa53c7cd4,
                0xe2b49ed9,
                0x3d406f43,
                0x1bbac807,
                0x6c593c0,
                0x5ba41b3a,
                0x2b2ac5a5,
                0x6959d8d2,
                0xb2f06eec,
                0x4c031e3e,
                0x724a5e63,
                0x22b9c3af,
        };
        private static uint[] keys2 = new uint[]
        {
                0xb7b37822,
                0xf9fad75d,
                0x12ae77f4,
                0x8ac19b50,
                0x37e72065,
                0x17f3c655,
                0x3bd27624,
                0x961f24ac,
                0xd7feb1a7,
                0xfec04afc,
                0xf8048e1f,
                0x76d166c4,
                0xafe26299,
                0x81ae7b00,
                0xe7228c95,
                0xe9e63536,
                0x8c5f4049,
                0x906a4bf8,
                0xe366d946,
                0xbd086f29,
                0xe6ed0f17,
                0xd7d9c3d0,
                0x452cea67,
                0x5de3cf25,
                0x7defeed,
                0xb01336c,
                0xfddc79ce,
                0xa466781f,
                0x74749bf,
                0xca96a6a9,
                0x9c6e8598,
                0xc0694b76,
                0x96fdf10c,
                0x4f7f705,
                0x1e9735e1,
                0x331ac7f7,
                0x92c6a591,
                0x70d3c3ad,
                0x6294c32a,
                0x6c5fc39f,
                0x1ea9d367,
                0x3a778822,
                0xcd185919,
                0xa4ef7d18,
                0xb2f64e15,
                0x78ea7348,
                0x737da1cb,
                0xfe8ee3aa,
                0xa81b890e,
                0x5e649c3a,
                0x8e107840,
                0x466c56ec,
                0xfc48db78,
                0x8f8329e,
                0xd572639c,
                0x3a020c20,
                0xeb07227c,
                0x6f2b0440,
                0xd534e360,
                0xc56fe06f,
                0xaffe4fcf,
                0xd387763d,
                0x33fdafa6,
                0xed9add21,
                0x67f52ae3,
                0x92fd06ca,
                0x5b23c32d,
                0x33f6af56,
                0x4810010b,
                0x86267448,
                0xbe896be2,
                0x93c65783,
                0xb7863167,
                0xbcfb4b0e,
                0x3871cfbd,
                0xb6f403e,
                0x7ec0848e,
                0xfebba3e3,
                0x3c1c16f0,
                0xc9e1f63a,
                0x8ee4ca93,
                0x2d8d9fc,
                0x470cf4a4,
                0x99e3965,
                0xd6a6be98,
                0x2b25b7f6,
                0x9c731f19,
                0x2ac72fc,
                0xfcf35de8,
                0x1dccf60b,
                0xadd6217f,
                0x35e11b71,
                0x5ef2747c,
                0xdeb351d8,
                0x14bc5f0d,
                0xa2fa56ce,
                0x162ddf30,
                0x424af12d,
                0x2a44ed64,
                0x38c6d231,
                0x78322ee,
                0xb7c15f55,
                0x6b8a9b9e,
                0x9823dda5,
                0xb3062077,
                0x3b5977a5,
                0xcf03fbce,
                0xce21af77,
                0xb811f928,
                0x5debfe48,
                0xf15576d5,
                0x1d8c44da,
                0xa41d05c7,
                0x73e79064,
                0x969c168b,
                0x84903286,
                0xdf25ebde,
                0x7ee63cbf,
                0xccd8742f,
                0x7efb86b4,
                0x5a197290,
                0x2d676f26,
                0xf1d558d2,
                0x3212d0c3,
                0x678696fd,
                0xb8dd8824,
                0x3d99211,
                0x4124057,
                0x28fc8ac,
                0x71194e18,
                0x97b5ffd1,
                0xa0239922,
                0x1337aa43,
                0x5445e18a,
                0x4e35bcd,
                0x59404f8,
                0x4a07c5c5,
                0xd9cece93,
                0xf56f7af0,
                0x47963cbd,
                0xe3cc9f56,
                0x1d05faa,
                0xe0ff7bdd,
                0x8cf08d89,
                0x9d177e6c,
                0x7f41be96,
                0x7d6aa944,
                0x8137e2fd,
                0x538e060b,
                0xab2f7aa,
                0x6945b304,
                0xb46ec53f,
                0xa884afce,
                0x75188ec2,
                0x8675a7aa,
                0xc4ca5699,
                0x6c592c9c,
                0xfd34e31a,
                0x99f90670,
                0x2c325c6c,
                0x42ce19dd,
                0x7da0b523,
                0x39184451,
                0xc6310a58,
                0x7177c5e1,
                0xb4853f38,
                0x40adcf9d,
                0x7983c516,
                0xd994dee8,
                0xe3e5a618,
                0xde65d12f,
                0xd6528288,
                0xbd6e9d3,
                0x7d118ff1,
                0x642edbc1,
                0x7296e111,
                0xba3941ce,
                0xbce984bc,
                0x346deb08,
                0xfeab443d,
                0x98cf2761,
                0xbcf2c209,
                0xba40ae3f,
                0xf9b05d41,
                0x700015e0,
                0xaf795ad7,
                0x3b1c42a8,
                0xbf3954b9,
                0x42fc0b26,
                0x97da7932,
                0xd67ee448,
                0x1dcdb11f,
                0xab0c25d9,
                0xaf532a5b,
                0xc5750a04,
                0x88907db9,
                0x4b558c5a,
                0x15d4533,
                0x186df67d,
                0x7a6032dc,
                0xa3f4a1c1,
                0x658e7d46,
                0x4bed7604,
                0xcd07dd08,
                0xf527d72e,
                0x97a8617c,
                0xf797bfe,
                0x6b64919,
                0xadf969de,
                0x14663f4b,
                0x4de6f1fa,
                0xecd952bc,
                0x1515a635,
                0x5dfb0196,
                0xe13c344b,
                0xc538e30f,
                0xc2f665f5,
                0x3c219c8b,
                0x3a6ff02b,
                0x1acba704,
                0x4d767e5c,
                0xe7f3feea,
                0xd65e3d4c,
                0x24347316,
                0x4f1705c1,
                0x99deb2b1,
                0x70b9effd,
                0x95d7888d,
                0xdec8429,
                0x16a4763c,
                0xa7198167,
                0xe5261be9,
                0x5af896b2,
                0xa8a0939f,
                0x1d16cf4c,
                0xaa6b7bad,
                0xd599520,
                0x1c1b74b2,
                0xd2ac813e,
                0xd8ea9765,
                0x1cbd55ed,
                0xfc21d8ef,
                0x30349af1,
                0x5be45f71,
                0xb78ed2c6,
                0xcec2336c,
                0x3b02eb64,
                0x605e9ba7,
                0x88130865,
                0xc0f0fc9d,
                0xad032a15,
                0x1e616ad6,
                0xff0dcdfb,
                0xc1881af9,
                0xf7511df1,
                0xa1802a56,
        };
        private static uint[] keys3 = new uint[]
        {
                0xb8efe490,
                0xc91c16a0,
                0xf1c5132b,
                0xc59c5577,
                0x5f09e8a0,
                0x28b2817c,
                0x327c19c9,
                0x85377c75,
                0x1f01fb9,
                0x1854fc0e,
                0x9eb6b019,
                0x608a0a1a,
                0x3932ff1c,
                0xef66759a,
                0x576c6ba0,
                0x9015a520,
                0xccb19d69,
                0x6dc30809,
                0xe38db635,
                0xc3dd5cff,
                0xee5d65ec,
                0xa8136d65,
                0x1e81c9a,
                0x837056a1,
                0xacc55026,
                0x809f8b66,
                0x6509b841,
                0x4725c767,
                0x3e37d682,
                0xe2fb81d6,
                0x32abe62b,
                0xc01fbd9f,
                0xfc81a3d7,
                0x36709f80,
                0xb4d47a5b,
                0x70dd27cc,
                0x64976603,
                0x4dfe91ad,
                0x991ae2bf,
                0x2be932c5,
                0xfcdffc94,
                0x183eaa30,
                0xcfb06772,
                0xdca7916,
                0x94709221,
                0xe5a4b25c,
                0x8fd55552,
                0xc75a05c3,
                0xb8f5ab12,
                0x95b9ed33,
                0x56a21067,
                0xa83894cc,
                0x9981d9a8,
                0xda48423d,
                0xc9cbf03d,
                0xc5ef4842,
                0x75173db4,
                0xb9b430d5,
                0x38fd3fae,
                0xb42e189,
                0x23442c5a,
                0xeffe7c75,
                0x9e34e6a8,
                0x17ed1f00,
                0xa824a9de,
                0xc9053b83,
                0x7d354a9b,
                0x80883cd3,
                0x26d52083,
                0xdf526b3f,
                0xcb4ed51e,
                0x110820,
                0x8e1153f9,
                0x79a19eca,
                0xf14bacd1,
                0x3fe60169,
                0x842f9d92,
                0x3d767ac2,
                0x10099bdc,
                0x6bb60681,
                0x3ada673,
                0x29c26208,
                0xcec491c5,
                0xdc482ecc,
                0xdaae02b,
                0x40f14158,
                0x31d93b9c,
                0x23fc7e5,
                0x1e8ca09e,
                0x912b620a,
                0xfc9df46a,
                0x39290809,
                0xbf89179e,
                0xdf3de9fa,
                0xee2950f3,
                0xfbd3612,
                0xb8eef168,
                0xfe73a6a4,
                0xf2305a1e,
                0x7a4cd542,
                0x91a1ebd7,
                0x33c16669,
                0xc314e92e,
                0xf242ad85,
                0x7358f442,
                0x9f52e72a,
                0x4358fa72,
                0x224b7f37,
                0x4d24a9e7,
                0xc528bd68,
                0xc61249ce,
                0x666a00ea,
                0x15c2fed1,
                0x3073a448,
                0x558e3b17,
                0xebca6710,
                0xda3d1b46,
                0x48ad2eff,
                0x2e3e877,
                0xc9ae4dae,
                0x571274fb,
                0x8b53b061,
                0x9ff10c3b,
                0xa7b930cb,
                0x4dbeaa40,
                0x21d3c8cd,
                0xa3d1de65,
                0x8feadd19,
                0x4e6f922d,
                0x3bf53aca,
                0x994ed572,
                0x5568481e,
                0xceb06afd,
                0xe8d02afa,
                0x3108044,
                0x9d8512d2,
                0x66fb357f,
                0xfc04bab2,
                0xb9abc484,
                0x90539781,
                0xb67b1093,
                0x3700cd37,
                0x77ebd93b,
                0x82f94e7e,
                0xa38a0ca9,
                0x62209b6c,
                0xcaf9d099,
                0x4bf82c15,
                0x7f3b9a8f,
                0x8cd7c2f4,
                0x11067da7,
                0xd12332e4,
                0x2c764d6d,
                0x5bfb2f90,
                0xb32e62bb,
                0xfa65ff9b,
                0x72a1b303,
                0xf07ff5c2,
                0x772779c5,
                0x13411739,
                0xd8530198,
                0x30d3205d,
                0xd020bcb2,
                0xbac569e,
                0x99b70ec0,
                0x7e07e61a,
                0xb8d73fe5,
                0x9e961b72,
                0xaf905581,
                0x88fe3629,
                0xab5de6b9,
                0x8a5a9dd8,
                0xf31f4fde,
                0x4c3f341d,
                0xb804f580,
                0xc01fcb4c,
                0x213417b6,
                0xd8697cb7,
                0x3f98b44e,
                0x82939c9e,
                0xff5b05de,
                0x5f4ab725,
                0x49c012ae,
                0x8e74d545,
                0xa3627483,
                0x8fdc1344,
                0x5aa4135b,
                0x8f7a3f59,
                0x1881d65e,
                0x1c4fffd4,
                0x1846335e,
                0x6d9a8f67,
                0xbdc9818f,
                0x98adb166,
                0x5e693249,
                0x1177ef32,
                0x442cb6eb,
                0xebfa77ad,
                0x84ea59a0,
                0xad5777d,
                0xba5c50f7,
                0x5b7f3bed,
                0x1f8839b,
                0xd538c0a0,
                0xd0da15ae,
                0xaaaf3c31,
                0x9e572c55,
                0xc6152bb1,
                0x9a6e4857,
                0xedbab87e,
                0xc6c0cadf,
                0xa47370a,
                0x198b309a,
                0x123ee8a0,
                0x1cd86881,
                0x36abe0e4,
                0xd0a1ed9e,
                0xe4833433,
                0x85e53b4f,
                0x417b9335,
                0x6aa6b9da,
                0x1aab1086,
                0xbc3ee2e4,
                0x15b08c8b,
                0x666857df,
                0xadf6e28e,
                0xc72b17be,
                0x5ba0a457,
                0xfe36a01e,
                0x36d983be,
                0xb2cd698,
                0x7144c34f,
                0x6426b2aa,
                0xcdac6168,
                0x516f018,
                0x2c4b4fa3,
                0x9cf73204,
                0x6bd27dcf,
                0xdc76e148,
                0xe3aff22a,
                0x129c6302,
                0x43f9021f,
                0x4cfc12dd,
                0x4ad96832,
                0xd8dc4266,
                0x92fa04e4,
                0x7012ec2,
                0x7b2c08e1,
                0xaee9d3db,
                0xfa3ebb61,
                0xb5c6c07a,
                0x7aea2d76,
                0xfffd44c6,
                0x1c3cf9fc,
                0x350f4224,
                0xc811ef1a,
        };
        private static uint[] keys4 = new uint[]
        {
                0x5c03ac94,
                0xcf32d224,
                0x24cad433,
                0xf18a03de,
                0x5d94581,
                0x9dc41455,
                0x5b1e9e9e,
                0xc6766916,
                0xfceaecd4,
                0xdea27cfd,
                0xceb2de6c,
                0xb826c36b,
                0x2ef33175,
                0x2c2f36dc,
                0xf1ebcd03,
                0xb11a752,
                0x841ec2bc,
                0x875f99bb,
                0xf4c4fcd4,
                0x7bc58e,
                0x3a083cb7,
                0x287edf1f,
                0x65e382c5,
                0xa5c7214e,
                0xa42cd1fe,
                0x7f130ab2,
                0xf77a7821,
                0xbabaccac,
                0x4b326ee1,
                0xc6ee9432,
                0xa9d9fe50,
                0x16d4345e,
                0xf33a84ba,
                0xc35380a1,
                0xf1d8dbf2,
                0xcd1cf88,
                0x33ae1919,
                0x3ee506a6,
                0xb3f76724,
                0xefb38c9f,
                0xbcf1b3aa,
                0x3f62037f,
                0x383fc278,
                0x453db8b0,
                0xb994705a,
                0x8674a567,
                0xf8b5f112,
                0x9d285339,
                0xa26dc0a6,
                0xb9c22ef1,
                0xd6b85f51,
                0x21ea2fa3,
                0x3aae121d,
                0x80aa01a2,
                0xfcdc3720,
                0xfc429194,
                0xc734b451,
                0x9aec1acb,
                0x8ac5b58d,
                0xeef404cb,
                0x66410528,
                0xa11bfb58,
                0xade87118,
                0xcb4353f7,
                0xbc5a5c76,
                0xd31bec17,
                0x6bc0e922,
                0xb43fe025,
                0x23042516,
                0x1ea6955,
                0x85512c4c,
                0x81a43cc0,
                0x91e95ef5,
                0xd2035d70,
                0x1f065071,
                0x3071f4e4,
                0x6056cdab,
                0xc879b540,
                0x28c62420,
                0x65a0aea4,
                0x99f6de20,
                0x9f9fb2bc,
                0x3242249c,
                0x28cbb653,
                0x15910372,
                0x25dd57fc,
                0x2917ff71,
                0x49c8b61c,
                0x6d973d28,
                0x8028d9b3,
                0x22272358,
                0x2c9c3f08,
                0xccd48109,
                0xcb146938,
                0x10064a4e,
                0x65125021,
                0xcf7494c3,
                0xd95ab9f1,
                0x564b04dd,
                0xffeafc49,
                0xa7bf35aa,
                0x292add9e,
                0x4430064a,
                0x79ea47af,
                0x89743b45,
                0x1daa52dc,
                0x962f3458,
                0x9220e4c7,
                0x66cde7aa,
                0xeb66cf78,
                0x9005a783,
                0x13cc3523,
                0x19372a99,
                0x97e60a85,
                0x8c4f0df2,
                0x5d2fc288,
                0x5b37a6d5,
                0xfa2bfa6d,
                0xa180dd9,
                0x694b5e89,
                0xc9e45997,
                0xe2d80053,
                0x2dcfcae7,
                0x95bfe021,
                0xea5bdac1,
                0x77cc451e,
                0xf3f1b858,
                0x93b9647,
                0x6e6ae95,
                0xdf89618b,
                0x8167c25d,
                0xf4f4326b,
                0x2df37a03,
                0x86209f0e,
                0xd7b07c15,
                0xd2850e33,
                0xd444019e,
                0xda62e076,
                0x661876,
                0x543e2b81,
                0x2a431187,
                0x842a3c2c,
                0xf8fd5260,
                0xf0b03c0c,
                0xf667dbe0,
                0xcd4b3118,
                0xbb22f854,
                0xc2d71c45,
                0xa9e1f9e4,
                0x2816029,
                0x5845fb16,
                0x72466f8e,
                0x36738a2f,
                0x84f74777,
                0xd1c429e,
                0x4271bef9,
                0x5091c918,
                0x6e81d2e,
                0x96628f62,
                0x38f62903,
                0xdfad1eb5,
                0x3a5ee770,
                0xb72a5646,
                0xf755dcf5,
                0x31aa0c81,
                0x6d9f36b0,
                0x7b9fa57f,
                0x2bd469f4,
                0x576d4642,
                0x13dbe844,
                0x5ee61095,
                0x7bc91d,
                0xd1b74c2d,
                0x64d0e91f,
                0x55765041,
                0x3649d8f,
                0x276da161,
                0xeb48d97d,
                0xcf68dd23,
                0xd1ad5ff2,
                0x619e9f57,
                0x73fc1be,
                0x4b2ac676,
                0x66e93c06,
                0xe6c88195,
                0x9e10aba8,
                0x7f629a25,
                0xbaec854f,
                0x39139e6a,
                0xcd4f715f,
                0xaee17973,
                0x771a501b,
                0xfde417b9,
                0x34e088fe,
                0xc8868b54,
                0xa04dcd3,
                0x98eda3c,
                0xd06dfff0,
                0x752b4c38,
                0xf75c1abf,
                0xd409b172,
                0xf82838ad,
                0x8b28f4a7,
                0x463078b7,
                0x2fc0cf32,
                0xdc8a83d8,
                0xba10cf85,
                0x235c0a4a,
                0xa292d6a1,
                0xdd3592bd,
                0x8305f8c0,
                0xc824e296,
                0xcae43c9c,
                0x384ebdfc,
                0xb4e4a8a,
                0xc7d351ae,
                0x8fafa344,
                0x12aa75f4,
                0x17e05d59,
                0xee25b4ac,
                0x26b834e3,
                0xddd38f65,
                0xd4108ded,
                0xd6d8e64,
                0x9f142145,
                0xb03eab18,
                0x91c14530,
                0x3b113ef6,
                0x1d3fa99f,
                0x3ee26d5e,
                0xe08f2385,
                0x21d1596e,
                0xf522506f,
                0xed5552e4,
                0x42de4ae,
                0xdf177f01,
                0x766bca3d,
                0x16839a9b,
                0x7385dbd7,
                0x7e4f110e,
                0xdfcc72d2,
                0x16d910d6,
                0x4aeeffd3,
                0x6e23a932,
                0x50e15916,
                0xb4165821,
                0xe8c7bdea,
                0x85a9894e,
                0x81b5bcbc,
                0xc125342d,
                0x2b06336a,
                0xbc68da95,
                0xba47204d,
                0x3b3dac64,
                0x1f90398b,
                0x9731de09,
        };
        private static uint HEADER_SIZE = 0x20;

        private static uint ReadUint32(byte[] buffer, uint startIndex)
        {
            return (uint)(buffer[startIndex] | (buffer[startIndex + 1] << 8) | (buffer[startIndex + 2] << 16) |(buffer[startIndex + 3] << 24));
        }
        private static void WriteUInt32(byte[] buffer, uint startIndex, uint newValue)
        {
            buffer[startIndex] = (byte)newValue;
            buffer[startIndex + 1] = (byte)(newValue >> 8);
            buffer[startIndex + 2] = (byte)(newValue >> 16);
            buffer[startIndex + 3] = (byte)(newValue >> 24);
        }
        private static void DecryptKit4(byte[] buffer)
        {
            if (buffer == null || buffer.Length == 0) return;
            uint size = ReadUint32(buffer, 4);

            for (uint i = HEADER_SIZE; i < size + HEADER_SIZE; i+=8)
            {
                uint a = ReadUint32(buffer, i);
                uint b = ReadUint32(buffer, i + 4);
                int key0Index = keys0.Length - 1;
                uint aux;
                do
                {
                    uint key0 = keys0[key0Index];
                    aux = a ^ key0;

                    a = (keys1[aux >> 0x18] + keys2[aux >> 0x10 & 0xff] ^ keys3[aux >> 8 & 0xff]) + keys4[aux & 0xff] ^ b;
                    b = aux;

                    key0Index--;
                } while (key0Index > 0);
                uint newA = b ^ 0xfe97fa19;
                uint newB = a ^ 0xb506bd9c;

                WriteUInt32(buffer, i, newA);
                WriteUInt32(buffer, i + 4, newB);
            }
        }
        private static void EncryptKit4(byte[] buffer)
        {
            if (buffer == null || buffer.Length == 0) return;
            uint size = ReadUint32(buffer, 4);

            for (uint i = HEADER_SIZE; i < size + HEADER_SIZE; i += 8)
            {
                uint newA = ReadUint32(buffer, i);
                uint newB = ReadUint32(buffer, i + 4);

                uint b = newA ^ 0xfe97fa19;
                uint a = newB ^ 0xb506bd9c;
                int key0Index = 1;
                uint aux;
                do
                {
                    uint key0 = keys0[key0Index];
                    aux = b;

                    b = a ^ ((keys1[aux >> 0x18] + keys2[aux >> 0x10 & 0xff] ^ keys3[aux >> 8 & 0xff]) + keys4[aux & 0xff]);
                    a = aux ^ key0;

                    key0Index++;
                } while (key0Index < keys0.Length);

                WriteUInt32(buffer, i, a);
                WriteUInt32(buffer, i + 4, b);
            }
        }
        private static void DecryptKit5(byte[] buffer)
        {
            if (buffer == null || buffer.Length == 0) return;

            uint key1 = ReadUint32(buffer, 0x10);
            uint key2 = ReadUint32(buffer, 0x14);
            uint key3 = ReadUint32(buffer, 0x18);
            uint key4 = ReadUint32(buffer, 0x1c);

            if (key1 == 0 || key2 == 0 || key3 == 0 || key4 == 0) return;

            uint a = ReadUint32(buffer, 0x20);
            uint b = ReadUint32(buffer, 0x28);
            uint c = ReadUint32(buffer, 0x2c);
            uint d = ReadUint32(buffer, 0x3c);

            uint newA = key4 + key3 & 0x230ab3fe ^ a;
            uint newB = (key2 & 0xfea938f2) + key1 ^ b;
            uint newC = key4 - key2 & 0x8a10a67a ^ c;
            uint newD = key1 - (key3 & 0x37aa3bef) ^ d;

            WriteUInt32(buffer, 0x20, newA);
            WriteUInt32(buffer, 0x28, newB);
            WriteUInt32(buffer, 0x2c, newC);
            WriteUInt32(buffer, 0x3c, newD);
        }
        private static void DecryptKit6(byte[] buffer)
        {
            if (buffer == null || buffer.Length == 0) return;

            uint key1 = ReadUint32(buffer, 0x10);
            uint key2 = ReadUint32(buffer, 0x14);
            uint key3 = ReadUint32(buffer, 0x18);
            uint key4 = ReadUint32(buffer, 0x1c);

            if (key1 == 0 || key2 == 0 || key3 == 0 || key4 == 0) return;

            uint a = ReadUint32(buffer, 0x20);
            uint b = ReadUint32(buffer, 0x24);
            uint c = ReadUint32(buffer, 0x2c);
            uint d = ReadUint32(buffer, 0x34);

            uint newA = key4 + key3 & 0x2dd795acU ^ a;
            uint newB = key2 & 0x5d54fc78U + key1 ^ b;
            uint newC = key4 - (key2 & 0xf7b5b641) ^ c;
            uint newD = key1 - (key3 & 0x78d50165U) ^ d;

            WriteUInt32(buffer, 0x20, newA);
            WriteUInt32(buffer, 0x24, newB);
            WriteUInt32(buffer, 0x2c, newC);
            WriteUInt32(buffer, 0x34, newD);
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  -i <input file>   Input file (required).");
            Console.WriteLine("  -o <output file>  Output file (required).");
            Console.WriteLine("  -v <version>      Processing version (required). Possible values: 4, 5, 6.");
            Console.WriteLine("  -e                Encrypt (only needed for version 4).");
            Console.WriteLine("  -d                Decrypt (only needed for version 4).");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine("  To encrypt with version 4:");
            Console.WriteLine("    KitDecrypt.exe -i uni000ga.bin -o uni000ga_new.bin -v 4 -e");
            Console.WriteLine("  To decrypt with version 4:");
            Console.WriteLine("    KitDecrypt.exe -i uni000ga.bin -o uni000ga_new.bin -v 4 -d");
            Console.WriteLine("  To process with version 5:");
            Console.WriteLine("    KitDecrypt.exe -i uni000ga.bin -o uni000ga_new.bin -v 5");
            Console.WriteLine("  To process with version 6:");
            Console.WriteLine("    KitDecrypt.exe -i uni000ga.bin -o uni000ga_new.bin -v 6");
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp();
                return;
            }

            string inputFile = null;
            string outputFile = null;
            int version = 0;
            bool encrypt = false;
            bool decrypt = false;

            // Process the arguments
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-i":
                        if (i + 1 < args.Length)
                        {
                            inputFile = args[++i];
                        }
                        else
                        {
                            Console.WriteLine("An input file is required after -i.");
                            ShowHelp();
                            return;
                        }
                        break;
                    case "-o":
                        if (i + 1 < args.Length)
                        {
                            outputFile = args[++i];
                        }
                        else
                        {
                            Console.WriteLine("An output file is required after -o.");
                            ShowHelp();
                            return;
                        }
                        break;
                    case "-v":
                        if (i + 1 < args.Length)
                        {
                            if (!int.TryParse(args[++i], out version) || (version != 4 && version != 5 && version != 6))
                            {
                                Console.WriteLine("Version must be 4, 5, or 6.");
                                ShowHelp();
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("A version value is required after -v.");
                            ShowHelp();
                            return;
                        }
                        break;
                    case "-e":
                        encrypt = true;
                        break;
                    case "-d":
                        decrypt = true;
                        break;
                    default:
                        Console.WriteLine($"Unrecognized option: {args[i]}");
                        ShowHelp();
                        return;
                }
            }

            if (version != 4 || version != 5 || version != 6) 
            {
                Console.WriteLine("Unsupported version.");
                ShowHelp();
                return;
            }

            byte[] buffer = File.ReadAllBytes(inputFile);

            if (version == 4)
            {
                if (encrypt && decrypt)
                {
                    Console.WriteLine("You cannot use both encrypt and decrypt options with version 4.");
                    ShowHelp();
                    return;
                }
                if (encrypt)
                {
                    EncryptKit4(buffer);
                }
                else if (decrypt)
                {
                    DecryptKit4(buffer);
                }
                else
                {
                    Console.WriteLine("You must specify -e or -d for version 4.");
                    ShowHelp();
                    return;
                }
            }
            else if (version == 5)
            {
                DecryptKit5(buffer);
            }
            else if (version == 6)
            {
                DecryptKit6(buffer);
            }

            File.WriteAllBytes(outputFile, buffer);

        }
    }
}
