using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePractice
{
    class TraningSource
    {
        public static readonly string[] iuFaces = new string[] {
            /*"https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/iu-%E6%9D%8E%E7%9F%A5%E6%81%A9-1592068502.jpg?crop=0.502xw:1.00xh;0.498xw,0&resize=640:*",
            "https://images.chinatimes.com/newsphoto/2019-10-18/900/20191018005061.jpg",
            "https://i.epochtimes.com/assets/uploads/2020/02/191203045325100707-450x298.jpg",
            "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/00iu-new-drama-1562588257.jpg?crop=0.502xw:1.00xh;0.498xw,0&resize=640:*",
            "https://i.epochtimes.com/assets/uploads/2019/12/191223052816100707-450x300.jpg",
            "https://images.chinatimes.com/newsphoto/2020-08-24/900/20200824002897.jpg",
            "https://s.yimg.com/ny/api/res/1.2/qseblKYHC9WVz7yjkYUU9Q--~A/YXBwaWQ9aGlnaGxhbmRlcjtzbT0xO3c9NTAwO2g9NjI2/https://media.zenfs.com/zh-tw/mydaily.kr/60cf1cd62164dbc202588575e6947799",
            "https://image2.stheadline.com/f/1296p810/0x0/100/none/1adc4d7918562d7ef30c6bf2a6026e89/stheadline/inewsmedia/20200413/_2020041317445990487.jpg",
            "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/19121201-1576138536.jpg?crop=0.506xw:1.00xh;0.494xw,0&resize=640:*",
            "https://pgw.udn.com.tw/gw/photo.php?u=https://uc.udn.com.tw/photo/2019/10/29/realtime/7001911.jpg&x=0&y=0&sw=0&sh=0&sl=W&fw=1050",
            "https://attach.setn.com/newsimages/2019/05/18/1930315-XXL.jpg",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTaQjYtZ40cTYpqkMYXvjFyA7HVVs-Hk46jnw&usqp=CAU",
            "https://i1.wp.com/popbee.com/image/2018/10/IU_02.jpg?quality=95&",
            "https://i.pinimg.com/originals/36/49/2e/36492e3c2338b1aaa5bd652fdc9279ae.jpg",*/
            "https://img.ltn.com.tw/Upload/ent/page/800/2019/11/10/phpa2dNfH.jpg",
            "https://pgw.udn.com.tw/gw/photo.php?u=https://uc.udn.com.tw/photo/2020/03/03/99/7546262.jpg&x=0&y=0&sw=0&sh=0&sl=W&fw=1050",
            "https://og.momoshop.com.tw/1596096593746/goodsimg/0007/056/840/7056840_R.jpg",
            "https://i1.wp.com/popbee.com/image/2018/09/IU-korean-singer-10-anniversary-concert-teaser.jpg?quality=95&",
            "https://cdn2.ettoday.net/images/3614/d3614928.jpg",
            "https://attach.setn.com/newsimages/2019/08/30/2102292-XXL.jpg",
            "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/19110802-1573206177.jpg?crop=0.506xw:1.00xh;0,0&resize=640:*",
            "https://a.ksd-i.com/a/2020-03-04/124787-820426.jpg",
            "https://images.newtalk.tw/resize_action2/600/album/news/375/5e5f7f91abf1c.JPG",
            "https://images.chinatimes.com/newsphoto/2020-05-19/900/20200519002591.jpg"
        };
        public static readonly string[] bearFaces = new string[]
        {
            "https://www.iza.ne.jp/kiji/world/images/201120/wor20112023080022-m1.jpg",
            "https://www.1242.com/lf/asset/uploads/2017/08/Xi_Jinping_2016a.jpg",
            "https://th.bing.com/th/id/OIP.658xcziVvAz67uZ5m-0ADgHaE-?pid=ImgDet&rs=1",
            "https://zjnews.zjol.com.cn/ztjj/2017sjdzt/sjdqmtbd/201710/W020171025690874672386.jpg",
            "https://th.bing.com/th/id/OIP.F9bAjDjRZ2eVhGybJRKlowHaE5?pid=ImgDet&rs=1",
            "https://news.1242.com/wp-content/uploads/2017/10/jpp025321783a-1.jpg",
            "https://static.ffx.io/images/$zoom_1%2C$multiply_0.5633802816901409%2C$ratio_1.777778%2C$width_1420%2C$x_272%2C$y_68/t_crop_custom/t_sharpen%2Cq_auto%2Cf_auto/9e21f41c2a9344b6fcd534c26dd5ce748d4ea116",
            "https://th.bing.com/th/id/R.1abebef9f81b9268ab1290c333ac3659?rik=RqrQUZtZsS5XDA&riu=http%3a%2f%2fwww.qstheory.cn%2ftitlepic%2f112254%2f1122542585_1521099704438_title0h.jpg&ehk=0XfvDBpXbcgngFUJZimjEfkgkv2%2bpdbE6barGsATi7A%3d&risl=&pid=ImgRaw&r=0",
            "http://www.xinhuanet.com/politics/titlepic/112326/1123265657_1534470298560_title0h.jpg"
        };

        private static readonly string[] souceBoxItems = {"IU","習近平"};

        public static string[] SouceBoxItems => souceBoxItems;
    }
}
