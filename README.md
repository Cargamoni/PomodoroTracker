# PomodoroTracker
Medyum Abla'nın da dediği gibi;
1980 yılında Francesco Cirillo tarafından icat edilen Pomodoro Tekniğinden bahsetmek istiyorum. Yazılım sektöründe uzun yıllar çalışan Francesco, zamanı etkin ve verimli kullanmakla ilgili çalışmalarda bulunmuş. Pomodoro Tekniğini için mutfaktaki zaman sayaçlarından ilham almış :) Zira Pomodoro İtalyanca’da domates demek.

######Medyum Abla'nın linki [Medium](https://medium.com/@fundakoca/zaman-y%C3%B6netimi-i%CC%87%C3%A7in-pomodoro-tekni%C4%9Fi-1fef1bc165d4 "Medium")

Bilmiyorum masa üstü versiyonu var mı pek de araştırdığım söylenemez, benim gibi offline severler için kullanılabilir bir versiyon oldu diyeibliriz.

- Build Edilmiş Versiyon

Hala geliştirilme aşamasında olduğundan çeşitli eklemeler yaptıkça build edilmiş versiyona buradan erişebilirsiniz, GNU/Linux işletim sistemlerinde Mono-Project ile çalıştırılabilir hale getirilebilir.

Not: Şimdilik sadece Ubuntu 18.04 üzerine test edilmiştir.

- Mono-Project ve Libcurl 

`$ sudo apt install libcurl4-openssl-dev mono-complete ca-certificates-mono`

Tüm Mono-Project'i değil sadece çalıştırabilecek kadarını indirmek isterseniz

`sudo apt install libcurl4-openssl-dev ca-certificates-mono libmono-accessibility4.0-cil libmono-addins-gui0.2-cil libmono-addins0.2-cil libmono-cairo4.0-cil libmono-corlib4.5-cil libmono-data-tds4.0-cil libmono-i18n-west4.0-cil libmono-i18n4.0-cil libmono-ldap4.0-cil libmono-microsoft-csharp4.0-cil libmono-posix4.0-cil libmono-security4.0-cil libmono-sharpzip4.84-cil libmono-sqlite4.0-cil libmono-system-componentmodel-dataannotations4.0-cil libmono-system-configuration4.0-cil libmono-system-core4.0-cil libmono-system-data4.0-cil libmono-system-design4.0-cil libmono-system-drawing4.0-cil libmono-system-enterpriseservices4.0-cil libmono-system-ldap4.0-cil libmono-system-net-http-webrequest4.0-cil libmono-system-net-http4.0-cil libmono-system-numerics4.0-cil libmono-system-runtime-serialization-formatters-soap4.0-cil libmono-system-runtime-serialization4.0-cil libmono-system-security4.0-cil libmono-system-servicemodel-internals0.0-cil libmono-system-transactions4.0-cil libmono-system-web-applicationservices4.0-cil libmono-system-web-services4.0-cil libmono-system-web4.0-cil libmono-system-windows-forms4.0-cil libmono-system-xml-linq4.0-cil libmono-system-xml4.0-cil libmono-system4.0-cil libmono-webbrowser4.0-cil libmono-zeroconf1.0-cil mono-4.0-gac mono-gac mono-runtime mono-runtime-common mono-runtime-sgen`

Bu yöntem denenmedi ancak geri dönüşlere her zaman açığım (:

Programlamada kullanılan programlama dili her ne kadar özgür olmayan bir programlama dili olsa da uygulamayı GNU Public License ile lisanslamak istedim, bundan bile güzel bir şey çıkarabilmek için.

#####Meraklısına [GNU Public License] (https://www.gnu.org/licenses/gpl-3.0.html "GNU.ORG")