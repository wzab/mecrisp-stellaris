\ 255 x 6 bytes for 5x7 font character bit maps
\ High and low bytes of halfwords are switched for storage by
\ custom word h<>, so array indices act as if they were for a byte array
\ when accessing it with c@ word.
create 5x7FONT
  $0000 h><, $0000 h><, $0000 h><,  \ 0
  $3E5B h><, $4F5B h><, $3E00 h><,  \ 1
  $3E6B h><, $4F6B h><, $3E00 h><,  \ 2
  $1C3E h><, $7C3E h><, $1C00 h><,  \ 3
  $183C h><, $7E3C h><, $1800 h><,  \ 4
  $1C57 h><, $7D57 h><, $1C00 h><,  \ 5
  $1C5E h><, $7F5E h><, $1C00 h><,  \ 6
  $0018 h><, $3C18 h><, $0000 h><,  \ 7
  $FFE7 h><, $C3E7 h><, $FF00 h><,  \ 8
  $0018 h><, $2418 h><, $0000 h><,  \ 9
  $FFE7 h><, $DBE7 h><, $FF00 h><,  \ 10
  $3048 h><, $3A06 h><, $0E00 h><,  \ 11
  $2629 h><, $7929 h><, $2600 h><,  \ 12
  $407F h><, $0505 h><, $0700 h><,  \ 13
  $407F h><, $0525 h><, $3F00 h><,  \ 14
  $5A3C h><, $E73C h><, $5A00 h><,  \ 15
  $7F3E h><, $1C1C h><, $0800 h><,  \ 16
  $081C h><, $1C3E h><, $7F00 h><,  \ 17
  $1422 h><, $7F22 h><, $1400 h><,  \ 18
  $5F5F h><, $005F h><, $5F00 h><,  \ 19
  $0609 h><, $7F01 h><, $7F00 h><,  \ 20
  $0066 h><, $8995 h><, $6A00 h><,  \ 21
  $6060 h><, $6060 h><, $6000 h><,  \ 22
  $94A2 h><, $FFA2 h><, $9400 h><,  \ 23
  $0804 h><, $7E04 h><, $0800 h><,  \ 24
  $1020 h><, $7E20 h><, $1000 h><,  \ 25
  $0808 h><, $2A1C h><, $0800 h><,  \ 26
  $081C h><, $2A08 h><, $0800 h><,  \ 27
  $1E10 h><, $1010 h><, $1000 h><,  \ 28
  $0C1E h><, $0C1E h><, $0C00 h><,  \ 29
  $3038 h><, $3E38 h><, $3000 h><,  \ 30
  $060E h><, $3E0E h><, $0600 h><,  \ 31
  $0000 h><, $0000 h><, $0000 h><,  \ 32 space
  $0000 h><, $5F00 h><, $0000 h><,  \ 33 !
  $0007 h><, $0007 h><, $0000 h><,  \ 34 "
  $147F h><, $147F h><, $1400 h><,  \ 35 #
  $242A h><, $7F2A h><, $1200 h><,  \ 36 $
  $2313 h><, $0864 h><, $6200 h><,  \ 37 %
  $3649 h><, $5620 h><, $5000 h><,  \ 38 &
  $0008 h><, $0703 h><, $0000 h><,  \ 39 '
  $001C h><, $2241 h><, $0000 h><,  \ 40 (
  $0041 h><, $221C h><, $0000 h><,  \ 41 )
  $2A1C h><, $7F1C h><, $2A00 h><,  \ 42 *
  $0808 h><, $3E08 h><, $0800 h><,  \ 43 +
  $0080 h><, $7030 h><, $0000 h><,  \ 44  h,
  $0808 h><, $0808 h><, $0800 h><,  \ 45 -
  $0000 h><, $6060 h><, $0000 h><,  \ 46 .
  $2010 h><, $0804 h><, $0200 h><,  \ 47 /
  $3E51 h><, $4945 h><, $3E00 h><,  \ 48 0
  $0042 h><, $7F40 h><, $0000 h><,  \ 49 1
  $7249 h><, $4949 h><, $4600 h><,  \ 50 2
  $2141 h><, $494D h><, $3300 h><,  \ 51 3
  $1814 h><, $127F h><, $1000 h><,  \ 52 4
  $2745 h><, $4545 h><, $3900 h><,  \ 53 5
  $3C4A h><, $4949 h><, $3100 h><,  \ 54 6
  $4121 h><, $1109 h><, $0700 h><,  \ 55 7
  $3649 h><, $4949 h><, $3600 h><,  \ 56 8
  $4649 h><, $4929 h><, $1E00 h><,  \ 57 9
  $0000 h><, $1400 h><, $0000 h><,  \ 58 :
  $0040 h><, $3400 h><, $0000 h><,  \ 59 ;
  $0008 h><, $1422 h><, $4100 h><,  \ 60 <
  $1414 h><, $1414 h><, $1400 h><,  \ 61 =
  $0041 h><, $2214 h><, $0800 h><,  \ 62 >
  $0201 h><, $5909 h><, $0600 h><,  \ 63 ?
  $3E41 h><, $5D59 h><, $4E00 h><,  \ 64 @
  $7C12 h><, $1112 h><, $7C00 h><,  \ 65 A
  $7F49 h><, $4949 h><, $3600 h><,  \ 66 B
  $3E41 h><, $4141 h><, $2200 h><,  \ 67 C
  $7F41 h><, $4141 h><, $3E00 h><,  \ 68 D
  $7F49 h><, $4949 h><, $4100 h><,  \ 69 E
  $7F09 h><, $0909 h><, $0100 h><,  \ 70 F
  $3E41 h><, $4151 h><, $7300 h><,
  $7F08 h><, $0808 h><, $7F00 h><,
  $0041 h><, $7F41 h><, $0000 h><,
  $2040 h><, $413F h><, $0100 h><,
  $7F08 h><, $1422 h><, $4100 h><,
  $7F40 h><, $4040 h><, $4000 h><,
  $7F02 h><, $1C02 h><, $7F00 h><,
  $7F04 h><, $0810 h><, $7F00 h><,
  $3E41 h><, $4141 h><, $3E00 h><,
  $7F09 h><, $0909 h><, $0600 h><,
  $3E41 h><, $5121 h><, $5E00 h><,
  $7F09 h><, $1929 h><, $4600 h><,
  $2649 h><, $4949 h><, $3200 h><,
  $0301 h><, $7F01 h><, $0300 h><,
  $3F40 h><, $4040 h><, $3F00 h><,
  $1F20 h><, $4020 h><, $1F00 h><,
  $3F40 h><, $3840 h><, $3F00 h><,
  $6314 h><, $0814 h><, $6300 h><,
  $0304 h><, $7804 h><, $0300 h><,
  $6159 h><, $494D h><, $4300 h><,
  $007F h><, $4141 h><, $4100 h><,
  $0204 h><, $0810 h><, $2000 h><,
  $0041 h><, $4141 h><, $7F00 h><,
  $0402 h><, $0102 h><, $0400 h><,
  $4040 h><, $4040 h><, $4000 h><,
  $0003 h><, $0708 h><, $0000 h><,
  $2054 h><, $5478 h><, $4000 h><,
  $7F28 h><, $4444 h><, $3800 h><,
  $3844 h><, $4444 h><, $2800 h><,
  $3844 h><, $4428 h><, $7F00 h><,
  $3854 h><, $5454 h><, $1800 h><,
  $0008 h><, $7E09 h><, $0200 h><,
  $18A4 h><, $A49C h><, $7800 h><,
  $7F08 h><, $0404 h><, $7800 h><,
  $0044 h><, $7D40 h><, $0000 h><,
  $2040 h><, $403D h><, $0000 h><,
  $7F10 h><, $2844 h><, $0000 h><,
  $0041 h><, $7F40 h><, $0000 h><,
  $7C04 h><, $7804 h><, $7800 h><,
  $7C08 h><, $0404 h><, $7800 h><,
  $3844 h><, $4444 h><, $3800 h><,
  $FC18 h><, $2424 h><, $1800 h><,
  $1824 h><, $2418 h><, $FC00 h><,
  $7C08 h><, $0404 h><, $0800 h><,
  $4854 h><, $5454 h><, $2400 h><,
  $0404 h><, $3F44 h><, $2400 h><,
  $3C40 h><, $4020 h><, $7C00 h><,
  $1C20 h><, $4020 h><, $1C00 h><,
  $3C40 h><, $3040 h><, $3C00 h><,
  $4428 h><, $1028 h><, $4400 h><,
  $4C90 h><, $9090 h><, $7C00 h><,
  $4464 h><, $544C h><, $4400 h><,
  $0008 h><, $3641 h><, $0000 h><,
  $0000 h><, $7700 h><, $0000 h><,
  $0041 h><, $3608 h><, $0000 h><,
  $0201 h><, $0204 h><, $0200 h><,
  $3C26 h><, $2326 h><, $3C00 h><,
  $1EA1 h><, $A161 h><, $1200 h><,
  $3A40 h><, $4020 h><, $7A00 h><,
  $3854 h><, $5455 h><, $5900 h><,
  $2155 h><, $5579 h><, $4100 h><,
  $2154 h><, $5478 h><, $4100 h><,
  $2155 h><, $5478 h><, $4000 h><,
  $2054 h><, $5579 h><, $4000 h><,
  $0C1E h><, $5272 h><, $1200 h><,
  $3955 h><, $5555 h><, $5900 h><,
  $3954 h><, $5454 h><, $5900 h><,
  $3955 h><, $5454 h><, $5800 h><,
  $0000 h><, $457C h><, $4100 h><,
  $0002 h><, $457D h><, $4200 h><,
  $0001 h><, $457C h><, $4000 h><,
  $F029 h><, $2429 h><, $F000 h><,
  $F028 h><, $2528 h><, $F000 h><,
  $7C54 h><, $5545 h><, $0000 h><,
  $2054 h><, $547C h><, $5400 h><,
  $7C0A h><, $097F h><, $4900 h><,
  $3249 h><, $4949 h><, $3200 h><,
  $3248 h><, $4848 h><, $3200 h><,
  $324A h><, $4848 h><, $3000 h><,
  $3A41 h><, $4121 h><, $7A00 h><,
  $3A42 h><, $4020 h><, $7800 h><,
  $009D h><, $A0A0 h><, $7D00 h><,
  $3944 h><, $4444 h><, $3900 h><,
  $3D40 h><, $4040 h><, $3D00 h><,
  $3C24 h><, $FF24 h><, $2400 h><,
  $487E h><, $4943 h><, $6600 h><,
  $2B2F h><, $FC2F h><, $2B00 h><,
  $FF09 h><, $29F6 h><, $2000 h><,
  $C088 h><, $7E09 h><, $0300 h><,
  $2054 h><, $5479 h><, $4100 h><,
  $0000 h><, $447D h><, $4100 h><,
  $3048 h><, $484A h><, $3200 h><,
  $3840 h><, $4022 h><, $7A00 h><,
  $007A h><, $0A0A h><, $7200 h><,
  $7D0D h><, $1931 h><, $7D00 h><,
  $2629 h><, $292F h><, $2800 h><,
  $2629 h><, $2929 h><, $2600 h><,
  $3048 h><, $4D40 h><, $2000 h><,
  $3808 h><, $0808 h><, $0800 h><,
  $0808 h><, $0808 h><, $3800 h><,
  $2F10 h><, $C8AC h><, $BA00 h><,
  $2F10 h><, $2834 h><, $FA00 h><,
  $0000 h><, $7B00 h><, $0000 h><,
  $0814 h><, $2A14 h><, $2200 h><,
  $2214 h><, $2A14 h><, $0800 h><,
  $AA00 h><, $5500 h><, $AA00 h><,
  $AA55 h><, $AA55 h><, $AA00 h><,
  $0000 h><, $00FF h><, $0000 h><,
  $1010 h><, $10FF h><, $0000 h><,
  $1414 h><, $14FF h><, $0000 h><,
  $1010 h><, $FF00 h><, $FF00 h><,
  $1010 h><, $F010 h><, $F000 h><,
  $1414 h><, $14FC h><, $0000 h><,
  $1414 h><, $F700 h><, $FF00 h><,
  $0000 h><, $FF00 h><, $FF00 h><,
  $1414 h><, $F404 h><, $FC00 h><,
  $1414 h><, $1710 h><, $1F00 h><,
  $1010 h><, $1F10 h><, $1F00 h><,
  $1414 h><, $141F h><, $0000 h><,
  $1010 h><, $10F0 h><, $0000 h><,
  $0000 h><, $001F h><, $1000 h><,
  $1010 h><, $101F h><, $1000 h><,
  $1010 h><, $10F0 h><, $1000 h><,
  $0000 h><, $00FF h><, $1000 h><,
  $1010 h><, $1010 h><, $1000 h><,
  $1010 h><, $10FF h><, $1000 h><,
  $0000 h><, $00FF h><, $1400 h><,
  $0000 h><, $FF00 h><, $FF00 h><,
  $0000 h><, $1F10 h><, $1700 h><,
  $0000 h><, $FC04 h><, $F400 h><,
  $1414 h><, $1710 h><, $1700 h><,
  $1414 h><, $F404 h><, $F400 h><,
  $0000 h><, $FF00 h><, $F700 h><,
  $1414 h><, $1414 h><, $1400 h><,
  $1414 h><, $F700 h><, $F700 h><,
  $1414 h><, $1417 h><, $1400 h><,
  $1010 h><, $1F10 h><, $1F00 h><,
  $1414 h><, $14F4 h><, $1400 h><,
  $1010 h><, $F010 h><, $F000 h><,
  $0000 h><, $1F10 h><, $1F00 h><,
  $0000 h><, $001F h><, $1400 h><,
  $0000 h><, $00FC h><, $1400 h><,
  $0000 h><, $F010 h><, $F000 h><,
  $1010 h><, $FF10 h><, $FF00 h><,
  $1414 h><, $14FF h><, $1400 h><,
  $1010 h><, $101F h><, $0000 h><,
  $0000 h><, $00F0 h><, $1000 h><,
  $FFFF h><, $FFFF h><, $FF00 h><,
  $F0F0 h><, $F0F0 h><, $F000 h><,
  $FFFF h><, $FF00 h><, $0000 h><,
  $0000 h><, $00FF h><, $FF00 h><,
  $0F0F h><, $0F0F h><, $0F00 h><,
  $3844 h><, $4438 h><, $4400 h><,
  $7C2A h><, $2A3E h><, $1400 h><,
  $7E02 h><, $0206 h><, $0600 h><,
  $027E h><, $027E h><, $0200 h><,
  $6355 h><, $4941 h><, $6300 h><,
  $3844 h><, $443C h><, $0400 h><,
  $407E h><, $201E h><, $2000 h><,
  $0602 h><, $7E02 h><, $0200 h><,
  $99A5 h><, $E7A5 h><, $9900 h><,
  $1C2A h><, $492A h><, $1C00 h><,
  $4C72 h><, $0172 h><, $4C00 h><,
  $304A h><, $4D4D h><, $3000 h><,
  $3048 h><, $7848 h><, $3000 h><,
  $BC62 h><, $5A46 h><, $3D00 h><,
  $3E49 h><, $4949 h><, $0000 h><,
  $7E01 h><, $0101 h><, $7E00 h><,
  $2A2A h><, $2A2A h><, $2A00 h><,
  $4444 h><, $5F44 h><, $4400 h><,
  $4051 h><, $4A44 h><, $4000 h><,
  $4044 h><, $4A51 h><, $4000 h><,
  $0000 h><, $FF01 h><, $0300 h><,
  $E080 h><, $FF00 h><, $0000 h><,
  $0808 h><, $6B6B h><, $0800 h><,
  $3612 h><, $3624 h><, $3600 h><,
  $060F h><, $090F h><, $0600 h><,
  $0000 h><, $1818 h><, $0000 h><,
  $0000 h><, $1010 h><, $0000 h><,
  $3040 h><, $FF01 h><, $0100 h><,
  $001F h><, $0101 h><, $1E00 h><,
  $0019 h><, $1D17 h><, $1200 h><,
  $003C h><, $3C3C h><, $3C00 h><,
  $0000 h><, $0000 h><, $0000 h><,

