/*! meting.aplayer.js v0.2.1 | MIT License */$(document).ready(function(){function t(t,e){var a=[],r=t.dataset;a.element=t,a.music=e,a.showlrc=a.music[0].lrc?3:0,a.narrow="true"===r.narrow,a.autoplay="true"===r.autoplay,a.mutex="false"!==r.mutex,a.mode=r.mode||"circulation",a.preload=r.preload||"auto",a.listmaxheight=r.listmaxheight||"340px",a.theme=r.theme||"#e6d0b2",new APlayer(a)}var e="https://api.i-meto.com/meting/api";"undefined"!=typeof meting_api&&(e=meting_api),$.each($(".aplayer"),function(a,r){var i=r.dataset.id;if(i)$.getJSON(e,{server:r.dataset.server,type:r.dataset.type,id:i,rnd:Math.random()},function(e){t(r,e)});else{var o=[];o.title=r.dataset.title,o.author=r.dataset.author,o.url=r.dataset.url,o.pic=r.dataset.pic,o.lrc=r.dataset.lrc,t(r,[o])}})});