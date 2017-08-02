/* http://meyerweb.com/eric/tools/css/reset/
   v2.0 | 20110126
   License: none (public domain)
*/
@import url(../css/animate.css);
@import url(../js/dist/bigfoot-default.css);
html, body, div, span, applet, object, iframe, h1, h2, h3, h4, h5, h6, p, blockquote, pre, a, abbr, acronym, address, big, cite, code, del, dfn, em, img, ins, kbd, q, s, samp, small, strike, strong, sub, sup, tt, var, b, u, i, center, dl, dt, dd, ol, ul, li, fieldset, form, label, legend, table, caption, tbody, tfoot, thead, tr, th, td, article, aside, canvas, details, embed, figure, figcaption, footer, header, hgroup, menu, nav, output, ruby, section, summary, time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline; }

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure, footer, header, hgroup, menu, nav, section {
  display: block; }

body {
  line-height: 1; }

ol, ul {
  list-style: none; }

blockquote, q {
  quotes: none; }

blockquote:before, blockquote:after {
  content: '';
  content: none; }

q:before, q:after {
  content: '';
  content: none; }

div.x-goto-top {
  display: none;
  opacity: 0.9;
  z-index: 999999;
  position: fixed;
  bottom: 113px;
  right: 2%;
  margin-left: 40px;
  width: 38px;
  height: 38px;
  border-radius: 3px;
  cursor: pointer;
  background-color: #f5f5f5;
  border: 1px solid #0593d3;
}
div.x-goto-top:hover {
  background-color: #fafafa;
  border-color: #0482ba;
}
div.x-goto-top:hover div.x-arrow {
  border-bottom-color: #0482ba;
}
div.x-goto-top:hover div.x-stick {
  background-color: #0482ba;
}
div.x-goto-top div.x-arrow {
  position: absolute;
  left: 10px;
  top: -1px;
  width: 0;
  height: 0;
  border: 9px solid transparent;
  border-bottom-color: #0593d3;
}
div.x-goto-top div.x-stick {
  position: absolute;
  left: 15px;
  top: 15px;
  width: 8px;
  height: 14px;
  display: block;
  border-radius: 1px;
  background-color: #0593d3;
}

.post>h1:before, 
.post>h2:before, 
.post>h3:before, 
.post>h4:before, 
.post>h5:before, 
.post>h6:before {
    content: "#";
    color: #54a3b3;
    margin-right: 8px;
}

.bg {
  display: none;
  position: fixed;
  width: 100%;
  height: 100%;
  background: #f6f3f3;
  z-index: 2;
  top: 0;
  left: 0;
  opacity: 0.7;
}
        
.content {
 display: none;
 width: 300px;
 height: 200px;
 position: fixed;
 top: 50%;
 margin-top: -80px;
 background: #fff;
 z-index: 9999;
 left: 50%;
 margin-left: -150px;
        }
#qrc {
 display: block;
 margin-left: auto;
 margin-right: auto;
}

#qrr {
 text-align: center;
 color: #333333;
}

.post-meta .page-pv {
    
    margin-right: 0.5em;
    font-size: 0.8em;
    float: right;
}
i.fa.fa-spinner.fa-spin {
    font-size: 0.8em;
}

table {
  border-collapse: collapse;
  border-spacing: 0; }

table {
    -moz-box-sizing: border-box;
    box-sizing: border-box;
    margin: 1.75em 0;
    width: 100%;
    max-width: 100%;
    background-color: transparent;
}

table th,
table td {
    padding: 8px;
    line-height: 20px;
    text-align: left;
    vertical-align: top;
    border-top: #EFEFEF 1px solid;
}

table th { color: #000;border-bottom: 2px solid #848484;}

table thead:first-child tr:first-child th {
    border-top: 0;
}

table tbody + tbody { border-top: #EFEFEF 2px solid; }

table table table { background-color: #FFF; }

table tbody > tr:nth-child(odd) > td,
table tbody > tr:nth-child(odd) > th {
    background-color: #F6F6F6;
}

table.plain tbody > tr:nth-child(odd) > td,
table.plain tbody > tr:nth-child(odd) > th {
   background: transparent;
}

body {
  width: 100%;
  *zoom: 1; }
  body:before, body:after {
    content: "";
    display: table; }
  body:after {
    clear: both; }

html, body {
  height: 100%;
  cursor: url(../images/cursor.ico),auto;
  display: block; }
  
html {
  height: 100%;
  max-height: 100%; }

body {
  font-family: "ff-tisa-web-pro-1", "ff-tisa-web-pro-2", "Lucida Grande", "Hiragino Sans GB", "Hiragino Sans GB W3", "Microsoft YaHei", "WenQuanYi Micro Hei", sans-serif;
  font-size: 1em;
  color: #666666;
  -webkit-font-smoothing: antialiased; }

::selection {
  background: #f39ca4; }

::-moz-selection {
  background: #f39ca4; }

a {
  text-decoration: none;
  color: #458fd2; }
  a:hover {
    color: #1461a7;
    -o-transition: .5s;
    -ms-transition: .5s;
    -moz-transition: .5s;
    -webkit-transition: .5s; }

h1,
h2,
h3,
h4,
h5,
h5 {
  margin-top: 1.0em;
  margin-bottom: .5em;
  font-family: "ff-tisa-web-pro-1", "ff-tisa-web-pro-2", "Lucida Grande", "Hiragino Sans GB", "Hiragino Sans GB W3", "Microsoft YaHei", "WenQuanYi Micro Hei", sans-serif;
  font-weight: lighter;
  color: #333333;
  -webkit-font-smoothing: antialiased; }

h1 {
  margin-top: 0;
  font-size: 2.5em;
  line-height: 1.2em;
  letter-spacing: .05em; }

h2 {
  font-size: 2.0em; }

h3 {
  font-size: 1.6em; }

h4 {
  font-size: 1.2em; }

h4 {
  font-size: 1.1em; }

h5 {
  font-size: 1em; }

.archives .item {
    padding: 20px 0 12px 120px;
    overflow: hidden;
    border-bottom: 1px solid #eee;
}
.archives h3 {
	font-size: 15px;
    font-weight: bold;
    margin: 4px 0 0 -120px;
    float: left;
}
.archives-list {
    list-style: none;
    font-size: 15px;
    line-height: 20px;
}
.archives-list li {
    padding: 3px 0;
    overflow: hidden;
}
.archives-list time {
    margin-right: 5px;
    color: #999;
    display: inline-block;
    width: 35px;
    font-family: monospace;
}

p {
  margin-bottom: 1.3em;
  line-height: 1.7em; }

strong {
  font-weight: bold; }

em {
  font-style: italic; }

blockquote {
  padding: 10px 20px;
  margin: 0 0 20px;
  font-family: "ff-tisa-web-pro-1", "ff-tisa-web-pro-2", "Lucida Grande", "Hiragino Sans GB", "Hiragino Sans GB W3", "Microsoft YaHei", "WenQuanYi Micro Hei", sans-serif;
  font-weight: lighter;
  font-size: 1em;
  border-left: 3px solid #25688f; }
  blockquote p:last-child {
    margin-bottom: 0; }

ol, ul {
  margin: 0 0 1.3em 2.5em; }
  ol li, ul li {
    margin: 0 0 .2em 0;
    line-height: 1.6em; }
  ol ol, ol ul, ul ol, ul ul {
    margin: .1em 0 .2em 2em; }

ol {
  list-style-type: decimal; }

ul {
  list-style-type: disc; }

code {
  padding: .1em .4em;
  background: #e8f2fb;
  border: 1px solid #c9e1f6;
  border-radius: 3px;
  font-family: Consolas, Menlo, Monaco, Lucida Console, Liberation Mono, DejaVu Sans Mono, Bitstream Vera Sans Mono, Courier New, monospace, serif;
  font-size: .9em;
  vertical-align: bottom;
  word-wrap: break-word; }

pre {
  margin-bottom: 1.3em;
  padding: 1em 2.5%;
  background: #e8f2fb;
  border: 1px solid #c9e1f6;
  border-radius: 3px;
  font-family: Consolas, Menlo, Monaco, Lucida Console, Liberation Mono, DejaVu Sans Mono, Bitstream Vera Sans Mono, Courier New, monospace, serif;
  font-size: .9em;
  font-weight: normal;
  line-height: 1.3em;
  overflow: scroll; }
  pre code {
    padding: 0;
    background: none;
    border: none;
    word-wrap: normal; }

.date,
.time,
.author,
.tags {
  font-size: .8em;
  color: #c7c7c7; }
  .date a,
  .time a,
  .author a,
  .tags a {
    color: #666666; }
    .date a:hover,
    .time a:hover,
    .author a:hover,
    .tags a:hover {
      color: #458fd2; }

.excerpt {
  margin: 0;
  font-size: .9em;
  color: #999999; }

.throb{-webkit-animation:d 1.33s ease-in-out infinite;animation:d 1.33s ease-in-out infinite}

.intro {
  font-family: "ff-tisa-web-pro-1", "ff-tisa-web-pro-2", "Lucida Grande", "Hiragino Sans GB", "Hiragino Sans GB W3", "Microsoft YaHei", "WenQuanYi Micro Hei", sans-serif;
  font-size: 1.2em;
  font-weight: lighter;
  color: #999999; }

.block-heading {
  display: inline;
  float: left;
  width: 940px;
  margin: 0 10px;
  position: relative;
  bottom: -15px;
  font-size: .8em;
  font-weight: bold;
  text-align: center;
  text-transform: uppercase;
  letter-spacing: 1px; }


a.back_to_top:hover {
    cursor: pointer;
    border-color: #999;
}

.label {
  position: relative;
  display: inline-block;
  padding: 8px 18px 9px 18px;
  background: #BF1827;
  border-radius: 3px;
  text-align: center;
  color: #FFF; }

.container {
  position: relative;
  z-index: 500;
  width: 940px;
  margin: 0 auto; }

.content-wrapper {
  z-index: 800;
  width: 70%;
  margin-left: 30%; }

.content-wrapper__inner {
  margin: 0 10%;
  padding: 50px 0; }

.footer {
  display: block;
  padding: 2em 0 0 0;
  border-top: 2px solid #DDDDDD;
  font-size: .7em;
  color: #b3b3b3; }

.footer__copyright {
  display: block;
  margin-bottom: .7em; }
  .footer__copyright a {
    color: #a6a6a6;
    text-decoration: none; }
    .footer__copyright a:hover {
      color: #458fd2; }

.avatar,
.logo {
  border-radius: 50%;
  border: 3px solid #FFF;
  box-shadow: 0 0 1px 1px rgba(0, 0, 0, 0.3); }

hr {
  border: none; }

.section-title__divider {
  width: 30%;
  margin: 2.2em 0 2.1em 0;
  border-top: 1px solid #DDDDDD; }

.hidden {
  display: none !important; }

.post-comments {
  border-top: 1px solid #DDDDDD;
  padding: 60px 0; }

.post-meta {
  margin: 0 0 .4em 0;
  color: #c7c7c7; }

.post-meta__date {
  margin-right: .5em; }

.post-meta__tags {
  margin-left: .4em; }

.post-meta__author {
  margin-left: 1.5em; }

.post-meta__avatar {
  display: inline-block;
  width: 22px;
  height: 22px;
  margin: 0 .3em -.4em 0;
  border: none;
  box-shadow: none; }

.post img {
  max-width: 100%;
  margin: 0 auto;
  border-radius: 3px;
  text-align: center;
  display: block; }
.post pre {
  width: 95%;
  overflow: auto; }
.post hr {
  display: block;
  width: 30%;
  margin: 2em 0;
  border-top: 1px solid #DDDDDD; }

.panel {
  display: table;
  width: 100%;
  height: 100%; }

.panel__vertical {
  display: table-cell;
  vertical-align: middle; }

.panel-title {
  margin: 0 0 5px 0;
  font-size: 2.5em;
  letter-spacing: 4px;
  color: #FFF; }

.panel-subtitle {
  font-family: "ff-tisa-web-pro-1", "ff-tisa-web-pro-2", "Lucida Grande", "Hiragino Sans GB", "Hiragino Sans GB W3", "Microsoft YaHei", "WenQuanYi Micro Hei", sans-serif;
  font-size: 1.2em;
  font-weight: lighter;
  letter-spacing: 3px;
  color: #CCCCCC;
  -webkit-font-smoothing: antialiased; }

.panel-cover {
  display: block;
  position: fixed;
  z-index: 900;
  width: 100%;
  max-width: none;
  height: 100%;
  background: url(https://ooo.0o0.ooo/2017/04/24/58fcd1a7e5ce3.jpg) top left no-repeat #666666;
  background-size: cover; }

.panel-cover--collapsed {
  width: 30%;
  max-width: 700px; }

.panel-cover--overlay {
  display: block;
  position: absolute;
  z-index: 0;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  background-color: rgba(68, 68, 68, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(68, 68, 68, 0.6) 20%, rgba(0, 0, 0, 0.9));
  background-image: linear-gradient(140deg,rgba(68, 68, 68, 0.6) 20%, rgba(0, 0, 0, 0.9)); }

.panel-cover__logo {
  margin-bottom: .2em; }

.panel-cover__description {
  margin: 0 30px; }

.panel-cover__divider {
  width: 50%;
  margin: 20px auto;
  border-top: 1px solid rgba(255, 255, 255, 0.14); }

.panel-cover__divider--secondary {
  width: 15%; }

.panel-main {
  display: table;
  width: 100%;
  height: 100%; }

.panel-main__inner {
  display: table-cell;
  vertical-align: middle;
  position: relative;
  z-index: 800;
  padding: 0 60px; }

.panel-main__content {
  max-width: 620px;
  margin: 0 auto; }

.panel-main__content--fixed {
  width: 480px;
  transition: width 1s;
  -webkit-transition: width 1s;
  /* Safari */ }

.panel-inverted {
  font-weight: 100;
  text-align: center;
  color: #FFF;
  text-shadow: 0 1px 1px rgba(0, 0, 0, 0.4); }
  .panel-inverted a {
    color: #FFF; }

.cover-navigation {
  margin-top: 42px; }

.cover-navigation--social {
  margin-left: 30px; }

.cover-blue {
  background-color: rgba(37, 104, 163, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(37, 104, 163, 0.6) 20%, rgba(18, 51, 80, 0.8));
  background-image: linear-gradient(140deg,rgba(37, 104, 163, 0.6) 20%, rgba(18, 51, 80, 0.8)); }

.cover-green {
  background-color: rgba(21, 111, 120, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(21, 111, 120, 0.6) 20%, rgba(6, 31, 33, 0.8));
  background-image: linear-gradient(140deg,rgba(21, 111, 120, 0.6) 20%, rgba(6, 31, 33, 0.8)); }

.cover-purple {
  background-color: rgba(73, 50, 82, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(73, 50, 82, 0.6) 20%, rgba(17, 11, 19, 0.8));
  background-image: linear-gradient(140deg,rgba(73, 50, 82, 0.6) 20%, rgba(17, 11, 19, 0.8)); }

.cover-red {
  background-color: rgba(119, 31, 18, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(119, 31, 18, 0.6) 20%, rgba(30, 8, 5, 0.8));
  background-image: linear-gradient(140deg,rgba(119, 31, 18, 0.6) 20%, rgba(30, 8, 5, 0.8)); }

.cover-orange {
  background-color: rgba(174, 80, 4, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(174, 80, 4, 0.6) 20%, rgba(74, 34, 2, 0.8));
  background-image: linear-gradient(140deg,rgba(174, 80, 4, 0.6) 20%, rgba(74, 34, 2, 0.8)); }

.cover-slate {
  background-color: rgba(61, 66, 96, 0.6);
  background-image: -webkit-linear-gradient(-410deg, rgba(61, 66, 96, 0.6) 20%, rgba(21, 23, 34, 0.8));
  background-image: linear-gradient(140deg,rgba(61, 66, 96, 0.6) 20%, rgba(21, 23, 34, 0.8)); }

.cover-disabled {
  background: none; }

.btn, .navigation__item a {
  padding: 10px 20px;
  border: 1px solid #BF1827;
  border-radius: 20px;
  font-size: .9em;
  font-weight: bold;
  letter-spacing: 1px;
  text-shadow: none;
  color: #BF1827;
  -webkit-font-smoothing: antialiased; }
  .btn:hover, .navigation__item a:hover {
    color: #458fd2;
    border-color: #458fd2; }

.btn-border-small {
  border: 1px solid #4e97d8;
  border-radius: 20px;
  padding: 6px 8px;
  font-size: .8em;
  margin-left: 10px; }

.btn-secondary {
  border-color: #5BA4E5;
  color: #5BA4E5; }
  .btn-secondary:hover {
    color: #217fd2;
    border-color: #217fd2; }

.btn-tertiary {
  border-color: #999999;
  color: #999999; }
  .btn-tertiary:hover {
    color: #737373;
    border-color: #737373; }

.btn-large {
  padding: 10px 24px;
  font-size: 1.1em; }

.btn-small {
  padding: 8px 12px;
  font-size: .7em; }

.btn-mobile-menu {
  display: none;
  position: fixed;
  z-index: 9999;
  top: 0;
  right: 0;
  left: 0;
  width: 100%;
  height: 35px;
  background: #E83015;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  text-align: center; }

.btn-mobile-menu__icon,
.btn-mobile-close__icon {
  position: relative;
  top: 10px;
  color: #FFF; }

nav {
  display: inline-block;
  position: relative; }

.navigation {
  display: inline-block;
  float: left;
  position: relative;
  margin: 0;
  list-style-type: none; }

.navigation__item {
  display: inline-block;
  margin: 5px 1px 0 0;
  line-height: 1em; }
  .navigation__item a {
    display: block;
    position: relative;
    border-color: #FFF;
    color: #FFF;
    opacity: .8; }
    .navigation__item a:hover {
      color: #FFF;
      border-color: #FFF;
      opacity: 1; }

.navigation--social a {
  border: 0px;
  padding: 6px 8px 6px 9px; }
  .navigation--social a .label {
    display: none; }
  .navigation--social a .icon {
    display: block;
    font-size: 1.7em; }

.pagination {
  display: block;
  margin: 0 0 4em 0; }

.pagination__page-number {
  margin: 0;
  font-size: .8em;
  color: #999999; }

.pagination__newer {
  margin-right: 1em; }

.pagination__older {
  margin-left: 1em; }

i {
  font-family: 'entypo';
  font-weight: normal;
  font-style: normal;
  font-size: 18px; }

.social {
  font-size: 22px; }

.icon-social {
  font-family: 'entypo-social';
  font-size: 22px;
  display: block;
  position: relative; }

.post-list {
  margin: 0;
  padding: 0;
  list-style-type: none;
  text-align: left; }
  .post-list li {
    margin: 0 0 2.2em 0; }
    .post-list li:last-child hr {
      display: none; }

.post-list__post-title {
  margin-top: 0;
  margin-bottom: .2em;
  font-size: 1.5em;
  line-height: 1.3em; }
  .post-list__post-title a {
    color: #333333; }
    .post-list__post-title a:hover {
      color: #458fd2; }

.post-list__meta {
  display: block;
  margin: .7em 0 0 0;
  font-size: .9em;
  color: #c7c7c7; }

.post-list__meta--date {
  margin-right: .5em;
  color: #c7c7c7; }

.post-list__meta--tags {
  margin-left: .5em; }

.post-list__divider {
  width: 30%;
  margin: 2.2em 0 2.1em 0;
  border-top: 1px solid #DDDDDD; }

*:focus {
  outline: none; }

input[type="text"],
input[type="password"],
input[type="datetime"],
input[type="datetime-local"],
input[type="date"],
input[type="month"],
input[type="time"],
input[type="week"],
input[type="number"],
input[type="email"],
input[type="url"],
input[type="search"],
input[type="tel"] {
  width: 240px;
  padding: 1em 1em;
  background: #FFF;
  border: 1px solid #DDDDDD;
  border-radius: 3px;
  font-size: .9em;
  color: #666666; }
  input[type="text"]:focus,
  input[type="password"]:focus,
  input[type="datetime"]:focus,
  input[type="datetime-local"]:focus,
  input[type="date"]:focus,
  input[type="month"]:focus,
  input[type="time"]:focus,
  input[type="week"]:focus,
  input[type="number"]:focus,
  input[type="email"]:focus,
  input[type="url"]:focus,
  input[type="search"]:focus,
  input[type="tel"]:focus {
    border-color: #5BA4E5; }
  input[type="text"]::-webkit-input-placeholder,
  input[type="password"]::-webkit-input-placeholder,
  input[type="datetime"]::-webkit-input-placeholder,
  input[type="datetime-local"]::-webkit-input-placeholder,
  input[type="date"]::-webkit-input-placeholder,
  input[type="month"]::-webkit-input-placeholder,
  input[type="time"]::-webkit-input-placeholder,
  input[type="week"]::-webkit-input-placeholder,
  input[type="number"]::-webkit-input-placeholder,
  input[type="email"]::-webkit-input-placeholder,
  input[type="url"]::-webkit-input-placeholder,
  input[type="search"]::-webkit-input-placeholder,
  input[type="tel"]::-webkit-input-placeholder {
    color: #CCCCCC; }
  input[type="text"]::-moz-placeholder,
  input[type="password"]::-moz-placeholder,
  input[type="datetime"]::-moz-placeholder,
  input[type="datetime-local"]::-moz-placeholder,
  input[type="date"]::-moz-placeholder,
  input[type="month"]::-moz-placeholder,
  input[type="time"]::-moz-placeholder,
  input[type="week"]::-moz-placeholder,
  input[type="number"]::-moz-placeholder,
  input[type="email"]::-moz-placeholder,
  input[type="url"]::-moz-placeholder,
  input[type="search"]::-moz-placeholder,
  input[type="tel"]::-moz-placeholder {
    color: #CCCCCC; }
  input[type="text"]:-moz-placeholder,
  input[type="password"]:-moz-placeholder,
  input[type="datetime"]:-moz-placeholder,
  input[type="datetime-local"]:-moz-placeholder,
  input[type="date"]:-moz-placeholder,
  input[type="month"]:-moz-placeholder,
  input[type="time"]:-moz-placeholder,
  input[type="week"]:-moz-placeholder,
  input[type="number"]:-moz-placeholder,
  input[type="email"]:-moz-placeholder,
  input[type="url"]:-moz-placeholder,
  input[type="search"]:-moz-placeholder,
  input[type="tel"]:-moz-placeholder {
    color: #CCCCCC; }
  input[type="text"]:-ms-input-placeholder,
  input[type="password"]:-ms-input-placeholder,
  input[type="datetime"]:-ms-input-placeholder,
  input[type="datetime-local"]:-ms-input-placeholder,
  input[type="date"]:-ms-input-placeholder,
  input[type="month"]:-ms-input-placeholder,
  input[type="time"]:-ms-input-placeholder,
  input[type="week"]:-ms-input-placeholder,
  input[type="number"]:-ms-input-placeholder,
  input[type="email"]:-ms-input-placeholder,
  input[type="url"]:-ms-input-placeholder,
  input[type="search"]:-ms-input-placeholder,
  input[type="tel"]:-ms-input-placeholder {
    color: #CCCCCC; }

.read-more {
  margin-top: 1em;
  margin-bottom: 1em;
  padding-top: 1.2em;
  padding-bottom: 1em;
  border-top: 1px solid #DDDDDD; }

.read-more-item {
  display: inline-block;
  vertical-align: top;
  width: 48%; }

.read-more-item-dim {
  color: #4e97d8;
  font-size: .8em;
  line-height: 1.8em; }

@media all and (max-width: 960px) {
.read-more-item {
  padding-top: 1.2em;
  width: 100%; 
}
}

@media all and (max-width: 1100px) {
  .panel-cover__logo {
    width: 70px; }

  .panel-title {
    font-size: 2em; }

  .panel-subtitle {
    font-size: 1em; }

  .panel-cover__description {
    margin: 0 10px;
    font-size: .9em; }

  .navigation--social {
    margin-top: 5px;
    margin-left: 0; } }
@media all and (max-width: 960px) {
  .btn-mobile-menu {
    display: block; }

  .panel-main {
    display: table;
    position: relative; }

  .panel-cover--collapsed {
    width: 100%;
    max-width: none; }

  .panel-main__inner {
    display: table-cell;
    padding: 60px 10%; }

  .panel-cover__description {
    display: block;
    max-width: 600px;
    margin: 0 auto; }

  .panel-cover__divider--secondary {
    display: none; }

  .panel-cover {
    width: 100%;
    height: 100%;
    background-position: center center; }
    .panel-cover.panel-cover--collapsed {
      display: block;
      position: relative;
      height: auto;
      padding: 0;
      background-position: center center; }
      .panel-cover.panel-cover--collapsed .panel-main__inner {
        display: block;
        padding: 70px 0 30px 0; }
      .panel-cover.panel-cover--collapsed .panel-cover__logo {
        width: 60px;
        border-width: 2px; }
      .panel-cover.panel-cover--collapsed .panel-cover__description {
        display: none; }
      .panel-cover.panel-cover--collapsed .panel-cover__divider {
        display: none;
        margin: 1em auto; }

  .navigation-wrapper {
    display: none;
    position: fixed;
    top: 0;
    right: 0;
    left: 0;
    width: 100%;
    padding: 20px 0;
    background: rgba(61, 66, 96, 0.6);
    border-bottom: 1px solid rgba(255, 255, 255, 0.15); }
    .navigation-wrapper.visible {
      display: block; }

  .cover-navigation {
    display: block;
    position: relative;
    float: left;
    clear: left;
    width: 100%; }
    .cover-navigation .navigation {
      display: block;
      width: 100%; }
      .cover-navigation .navigation li {
        width: 80%;
        margin-bottom: .4em; }
    .cover-navigation.navigation--social {
      padding-top: 5px; }
      .cover-navigation.navigation--social .navigation li {
        display: inline-block;
        width: 25.8%; }

  .content-wrapper {
    width: 80%;
    max-width: none;
    margin: 0 auto; }

  .content-wrapper__inner {
    margin-right: 0;
    margin-left: 0; }

  .navigation__item {
    width: 100%;
    margin: 0 0 .4em 0; } }
@media all and (max-width: 340px) {
  .panel-main__inner {
    padding: 0 5%; }

  .panel-title {
    margin-bottom: .1em;
    font-size: 1.5em; }

  .panel-subtitle {
    font-size: .9em; }

  .btn, .navigation__item a {
    display: block;
    margin-bottom: .4em; } }
