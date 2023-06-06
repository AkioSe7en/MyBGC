; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [216 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 64
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 93
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 17
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 88
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 78
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 78
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 45
	i32 182336117, ; 7: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 79
	i32 209399409, ; 8: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 43
	i32 220171995, ; 9: System.Diagnostics.Debug => 0xd1f8edb => 1
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 59
	i32 231814094, ; 11: System.Globalization => 0xdd133ce => 6
	i32 232815796, ; 12: System.Web.Services => 0xde07cb4 => 106
	i32 261689757, ; 13: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 48
	i32 278686392, ; 14: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 63
	i32 280482487, ; 15: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 57
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 35
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 29
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 61
	i32 347068432, ; 19: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 21
	i32 385762202, ; 20: System.Memory.dll => 0x16fe439a => 27
	i32 441335492, ; 21: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 47
	i32 442521989, ; 22: Xamarin.Essentials => 0x1a605985 => 87
	i32 442565967, ; 23: System.Collections => 0x1a61054f => 7
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 56
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 15
	i32 469710990, ; 26: System.dll => 0x1bff388e => 25
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 57
	i32 486930444, ; 28: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 68
	i32 526420162, ; 29: System.Transactions.dll => 0x1f6088c2 => 102
	i32 540030774, ; 30: System.IO.FileSystem.dll => 0x20303736 => 5
	i32 545304856, ; 31: System.Runtime.Extensions => 0x2080b118 => 96
	i32 605376203, ; 32: System.IO.Compression.FileSystem => 0x24154ecb => 104
	i32 627609679, ; 33: Xamarin.AndroidX.CustomView => 0x2568904f => 52
	i32 663517072, ; 34: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 84
	i32 666292255, ; 35: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 40
	i32 690569205, ; 36: System.Xml.Linq.dll => 0x29293ff5 => 34
	i32 748832960, ; 37: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 19
	i32 749005617, ; 38: MyBGC.Android.dll => 0x2ca4eb31 => 0
	i32 775507847, ; 39: System.IO.Compression => 0x2e394f87 => 26
	i32 809851609, ; 40: System.Drawing.Common.dll => 0x30455ad9 => 99
	i32 843511501, ; 41: Xamarin.AndroidX.Print => 0x3246f6cd => 75
	i32 877678880, ; 42: System.Globalization.dll => 0x34505120 => 6
	i32 928116545, ; 43: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 93
	i32 955402788, ; 44: Newtonsoft.Json => 0x38f24a24 => 17
	i32 967690846, ; 45: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 61
	i32 974778368, ; 46: FormsViewGroup.dll => 0x3a19f000 => 12
	i32 975874589, ; 47: System.Xml.XDocument => 0x3a2aaa1d => 3
	i32 992768348, ; 48: System.Collections.dll => 0x3b2c715c => 7
	i32 994442037, ; 49: System.IO.FileSystem => 0x3b45fb35 => 5
	i32 1012816738, ; 50: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 77
	i32 1035644815, ; 51: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 39
	i32 1042160112, ; 52: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 90
	i32 1052210849, ; 53: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 65
	i32 1098259244, ; 54: System => 0x41761b2c => 25
	i32 1175144683, ; 55: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 82
	i32 1178241025, ; 56: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 72
	i32 1204270330, ; 57: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 40
	i32 1267360935, ; 58: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 83
	i32 1292207520, ; 59: SQLitePCLRaw.core.dll => 0x4d0585a0 => 20
	i32 1293217323, ; 60: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 54
	i32 1324164729, ; 61: System.Linq => 0x4eed2679 => 97
	i32 1364015309, ; 62: System.IO => 0x514d38cd => 98
	i32 1365406463, ; 63: System.ServiceModel.Internals.dll => 0x516272ff => 94
	i32 1376866003, ; 64: Xamarin.AndroidX.SavedState => 0x52114ed3 => 77
	i32 1395857551, ; 65: Xamarin.AndroidX.Media.dll => 0x5333188f => 69
	i32 1406073936, ; 66: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 49
	i32 1411638395, ; 67: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 31
	i32 1457743152, ; 68: System.Runtime.Extensions.dll => 0x56e36530 => 96
	i32 1460219004, ; 69: Xamarin.Forms.Xaml => 0x57092c7c => 91
	i32 1462112819, ; 70: System.IO.Compression.dll => 0x57261233 => 26
	i32 1469204771, ; 71: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 38
	i32 1543031311, ; 72: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 95
	i32 1565862583, ; 73: System.IO.FileSystem.Primitives => 0x5d552ab7 => 9
	i32 1582372066, ; 74: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 53
	i32 1592978981, ; 75: System.Runtime.Serialization.dll => 0x5ef2ee25 => 10
	i32 1622152042, ; 76: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 67
	i32 1624863272, ; 77: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 86
	i32 1636350590, ; 78: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 51
	i32 1639515021, ; 79: System.Net.Http.dll => 0x61b9038d => 28
	i32 1639986890, ; 80: System.Text.RegularExpressions => 0x61c036ca => 95
	i32 1657153582, ; 81: System.Runtime => 0x62c6282e => 32
	i32 1658241508, ; 82: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 80
	i32 1658251792, ; 83: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 92
	i32 1670060433, ; 84: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 48
	i32 1677501392, ; 85: System.Net.Primitives.dll => 0x63fca3d0 => 8
	i32 1701541528, ; 86: System.Diagnostics.Debug.dll => 0x656b7698 => 1
	i32 1711441057, ; 87: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 21
	i32 1729485958, ; 88: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 44
	i32 1739894630, ; 89: MyBGC.Android => 0x67b4af66 => 0
	i32 1766324549, ; 90: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 79
	i32 1776026572, ; 91: System.Core.dll => 0x69dc03cc => 24
	i32 1788241197, ; 92: Xamarin.AndroidX.Fragment => 0x6a96652d => 56
	i32 1808609942, ; 93: Xamarin.AndroidX.Loader => 0x6bcd3296 => 67
	i32 1813201214, ; 94: Xamarin.Google.Android.Material => 0x6c13413e => 92
	i32 1818569960, ; 95: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 73
	i32 1867746548, ; 96: Xamarin.Essentials.dll => 0x6f538cf4 => 87
	i32 1878053835, ; 97: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 91
	i32 1885059311, ; 98: MyBGC.dll => 0x705bb8ef => 16
	i32 1885316902, ; 99: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 41
	i32 1919157823, ; 100: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 70
	i32 2011961780, ; 101: System.Buffers.dll => 0x77ec19b4 => 23
	i32 2019465201, ; 102: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 65
	i32 2054170072, ; 103: CodeHollow.FeedReader => 0x7a7025d8 => 11
	i32 2055257422, ; 104: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 62
	i32 2079903147, ; 105: System.Runtime.dll => 0x7bf8cdab => 32
	i32 2090596640, ; 106: System.Numerics.Vectors => 0x7c9bf920 => 30
	i32 2097448633, ; 107: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 58
	i32 2103459038, ; 108: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 22
	i32 2126786730, ; 109: Xamarin.Forms.Platform.Android => 0x7ec430aa => 89
	i32 2201231467, ; 110: System.Net.Http => 0x8334206b => 28
	i32 2217644978, ; 111: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 82
	i32 2244775296, ; 112: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 68
	i32 2256548716, ; 113: Xamarin.AndroidX.MultiDex => 0x8680336c => 70
	i32 2261435625, ; 114: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 60
	i32 2279755925, ; 115: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 76
	i32 2315684594, ; 116: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 36
	i32 2353062107, ; 117: System.Net.Primitives => 0x8c40e0db => 8
	i32 2409053734, ; 118: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 74
	i32 2454642406, ; 119: System.Text.Encoding.dll => 0x924edee6 => 2
	i32 2465273461, ; 120: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 19
	i32 2465532216, ; 121: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 47
	i32 2471841756, ; 122: netstandard.dll => 0x93554fdc => 100
	i32 2475788418, ; 123: Java.Interop.dll => 0x93918882 => 13
	i32 2501346920, ; 124: System.Data.DataSetExtensions => 0x95178668 => 103
	i32 2505896520, ; 125: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 64
	i32 2581819634, ; 126: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 83
	i32 2620871830, ; 127: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 51
	i32 2624644809, ; 128: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 55
	i32 2633051222, ; 129: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 63
	i32 2664396074, ; 130: System.Xml.XDocument.dll => 0x9ecf752a => 3
	i32 2693849962, ; 131: System.IO.dll => 0xa090e36a => 98
	i32 2701096212, ; 132: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 80
	i32 2715334215, ; 133: System.Threading.Tasks.dll => 0xa1d8b647 => 4
	i32 2732626843, ; 134: Xamarin.AndroidX.Activity => 0xa2e0939b => 35
	i32 2737747696, ; 135: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 38
	i32 2742292717, ; 136: MyBGC => 0xa37410ed => 16
	i32 2766581644, ; 137: Xamarin.Forms.Core => 0xa4e6af8c => 88
	i32 2778768386, ; 138: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 85
	i32 2810250172, ; 139: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 49
	i32 2819470561, ; 140: System.Xml.dll => 0xa80db4e1 => 33
	i32 2853208004, ; 141: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 85
	i32 2855708567, ; 142: Xamarin.AndroidX.Transition => 0xaa36a797 => 81
	i32 2903344695, ; 143: System.ComponentModel.Composition => 0xad0d8637 => 105
	i32 2905242038, ; 144: mscorlib.dll => 0xad2a79b6 => 15
	i32 2916838712, ; 145: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 86
	i32 2919462931, ; 146: System.Numerics.Vectors.dll => 0xae037813 => 30
	i32 2921128767, ; 147: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 37
	i32 2978675010, ; 148: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 54
	i32 3024354802, ; 149: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 59
	i32 3044182254, ; 150: FormsViewGroup => 0xb57288ee => 12
	i32 3057625584, ; 151: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 71
	i32 3075834255, ; 152: System.Threading.Tasks => 0xb755818f => 4
	i32 3111772706, ; 153: System.Runtime.Serialization => 0xb979e222 => 10
	i32 3204380047, ; 154: System.Data.dll => 0xbefef58f => 101
	i32 3211777861, ; 155: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 53
	i32 3247949154, ; 156: Mono.Security => 0xc197c562 => 107
	i32 3258312781, ; 157: Xamarin.AndroidX.CardView => 0xc235e84d => 44
	i32 3267021929, ; 158: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 42
	i32 3286872994, ; 159: SQLite-net.dll => 0xc3e9b3a2 => 18
	i32 3299363146, ; 160: System.Text.Encoding => 0xc4a8494a => 2
	i32 3317135071, ; 161: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 52
	i32 3317144872, ; 162: System.Data => 0xc5b79d28 => 101
	i32 3340431453, ; 163: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 41
	i32 3346324047, ; 164: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 72
	i32 3353484488, ; 165: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 58
	i32 3360279109, ; 166: SQLitePCLRaw.core => 0xc849ca45 => 20
	i32 3362522851, ; 167: Xamarin.AndroidX.Core => 0xc86c06e3 => 50
	i32 3366347497, ; 168: Java.Interop => 0xc8a662e9 => 13
	i32 3374999561, ; 169: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 76
	i32 3395150330, ; 170: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 31
	i32 3404865022, ; 171: System.ServiceModel.Internals => 0xcaf21dfe => 94
	i32 3429136800, ; 172: System.Xml => 0xcc6479a0 => 33
	i32 3430777524, ; 173: netstandard => 0xcc7d82b4 => 100
	i32 3441283291, ; 174: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 55
	i32 3476120550, ; 175: Mono.Android => 0xcf3163e6 => 14
	i32 3486566296, ; 176: System.Transactions => 0xcfd0c798 => 102
	i32 3493954962, ; 177: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 46
	i32 3501239056, ; 178: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 42
	i32 3509114376, ; 179: System.Xml.Linq => 0xd128d608 => 34
	i32 3536029504, ; 180: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 89
	i32 3567349600, ; 181: System.ComponentModel.Composition.dll => 0xd4a16f60 => 105
	i32 3608519521, ; 182: System.Linq.dll => 0xd715a361 => 97
	i32 3618140916, ; 183: Xamarin.AndroidX.Preference => 0xd7a872f4 => 74
	i32 3627220390, ; 184: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 75
	i32 3632359727, ; 185: Xamarin.Forms.Platform => 0xd881692f => 90
	i32 3633644679, ; 186: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 37
	i32 3638274909, ; 187: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 9
	i32 3641597786, ; 188: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 62
	i32 3672681054, ; 189: Mono.Android.dll => 0xdae8aa5e => 14
	i32 3676310014, ; 190: System.Web.Services.dll => 0xdb2009fe => 106
	i32 3682565725, ; 191: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 43
	i32 3684561358, ; 192: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 46
	i32 3689375977, ; 193: System.Drawing.Common => 0xdbe768e9 => 99
	i32 3718780102, ; 194: Xamarin.AndroidX.Annotation => 0xdda814c6 => 36
	i32 3724971120, ; 195: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 71
	i32 3754567612, ; 196: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 22
	i32 3758932259, ; 197: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 60
	i32 3786282454, ; 198: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 45
	i32 3822602673, ; 199: Xamarin.AndroidX.Media => 0xe3d849b1 => 69
	i32 3829621856, ; 200: System.Numerics.dll => 0xe4436460 => 29
	i32 3876362041, ; 201: SQLite-net => 0xe70c9739 => 18
	i32 3885922214, ; 202: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 81
	i32 3896760992, ; 203: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 50
	i32 3920810846, ; 204: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 104
	i32 3921031405, ; 205: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 84
	i32 3931092270, ; 206: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 73
	i32 3945713374, ; 207: System.Data.DataSetExtensions.dll => 0xeb2ecede => 103
	i32 3955647286, ; 208: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 39
	i32 4025784931, ; 209: System.Memory => 0xeff49a63 => 27
	i32 4105002889, ; 210: Mono.Security.dll => 0xf4ad5f89 => 107
	i32 4151237749, ; 211: System.Core => 0xf76edc75 => 24
	i32 4182413190, ; 212: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 66
	i32 4234390579, ; 213: CodeHollow.FeedReader.dll => 0xfc63ac33 => 11
	i32 4260525087, ; 214: System.Buffers => 0xfdf2741f => 23
	i32 4292120959 ; 215: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 66
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [216 x i32] [
	i32 64, i32 93, i32 17, i32 88, i32 78, i32 78, i32 45, i32 79, ; 0..7
	i32 43, i32 1, i32 59, i32 6, i32 106, i32 48, i32 63, i32 57, ; 8..15
	i32 35, i32 29, i32 61, i32 21, i32 27, i32 47, i32 87, i32 7, ; 16..23
	i32 56, i32 15, i32 25, i32 57, i32 68, i32 102, i32 5, i32 96, ; 24..31
	i32 104, i32 52, i32 84, i32 40, i32 34, i32 19, i32 0, i32 26, ; 32..39
	i32 99, i32 75, i32 6, i32 93, i32 17, i32 61, i32 12, i32 3, ; 40..47
	i32 7, i32 5, i32 77, i32 39, i32 90, i32 65, i32 25, i32 82, ; 48..55
	i32 72, i32 40, i32 83, i32 20, i32 54, i32 97, i32 98, i32 94, ; 56..63
	i32 77, i32 69, i32 49, i32 31, i32 96, i32 91, i32 26, i32 38, ; 64..71
	i32 95, i32 9, i32 53, i32 10, i32 67, i32 86, i32 51, i32 28, ; 72..79
	i32 95, i32 32, i32 80, i32 92, i32 48, i32 8, i32 1, i32 21, ; 80..87
	i32 44, i32 0, i32 79, i32 24, i32 56, i32 67, i32 92, i32 73, ; 88..95
	i32 87, i32 91, i32 16, i32 41, i32 70, i32 23, i32 65, i32 11, ; 96..103
	i32 62, i32 32, i32 30, i32 58, i32 22, i32 89, i32 28, i32 82, ; 104..111
	i32 68, i32 70, i32 60, i32 76, i32 36, i32 8, i32 74, i32 2, ; 112..119
	i32 19, i32 47, i32 100, i32 13, i32 103, i32 64, i32 83, i32 51, ; 120..127
	i32 55, i32 63, i32 3, i32 98, i32 80, i32 4, i32 35, i32 38, ; 128..135
	i32 16, i32 88, i32 85, i32 49, i32 33, i32 85, i32 81, i32 105, ; 136..143
	i32 15, i32 86, i32 30, i32 37, i32 54, i32 59, i32 12, i32 71, ; 144..151
	i32 4, i32 10, i32 101, i32 53, i32 107, i32 44, i32 42, i32 18, ; 152..159
	i32 2, i32 52, i32 101, i32 41, i32 72, i32 58, i32 20, i32 50, ; 160..167
	i32 13, i32 76, i32 31, i32 94, i32 33, i32 100, i32 55, i32 14, ; 168..175
	i32 102, i32 46, i32 42, i32 34, i32 89, i32 105, i32 97, i32 74, ; 176..183
	i32 75, i32 90, i32 37, i32 9, i32 62, i32 14, i32 106, i32 43, ; 184..191
	i32 46, i32 99, i32 36, i32 71, i32 22, i32 60, i32 45, i32 69, ; 192..199
	i32 29, i32 18, i32 81, i32 50, i32 104, i32 84, i32 73, i32 103, ; 200..207
	i32 39, i32 27, i32 107, i32 24, i32 66, i32 11, i32 23, i32 66 ; 216..215
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
