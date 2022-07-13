function varargout = untitled2yeniklmn(varargin)
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @untitled2yeniklmn_OpeningFcn, ...
                   'gui_OutputFcn',  @untitled2yeniklmn_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end


function untitled2yeniklmn_OpeningFcn(hObject, eventdata, handles, varargin)
handles.output = hObject;
guidata(hObject, handles);

function varargout = untitled2yeniklmn_OutputFcn(hObject, eventdata, handles) 
varargout{1} = handles.output;


function etkisiz_eleman_1_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'0'));

function iki_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'2'));

function uc_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'3'));

function dort_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'4'));

function bes_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'5'));

function alti_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'6'));

function yedi_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'7'));

function sekiz_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'8'));

function dokuz_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'9'));

function bir_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'1'));

function nokta_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'.'));

function toplama_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'+'));

function cikarma_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'-'));

function carpma_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'*'));

function bolme_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
set(a,'String',strcat(b,'/'));

function esit_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
b=str2num(b);
b=num2str(b);
a=findobj(gcbf,'Tag','sonuc_bir');
set(a,'String',b)
x=findobj(gcbf,'Tag','sonuc_iki')
set(x,'String','');

function silme_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_bir');
b=(get(a,'String'));
c=findobj(gcbf,'Tag','sonuc_iki');
d=(get(c,'String'));
e=findobj(gcbf,'Tag','sonuc_iki');
set(e,'String',strcat(d,b));

function delete_Callback(hObject, eventdata, handles)
c=findobj(gcbf,'Tag','sonuc_iki');
set(c,'String','');
d=findobj(gcbf,'Tag','sonuc_bir');
set(d,'String','');
clear all;

function karakter_silme_Callback(hObject, eventdata, handles)
a=findobj(gcbf,'Tag','sonuc_iki');
b=get(a,'String');
b(end)='';
c=findobj(gcbf,'Tag','sonuc_iki');
set(c,'String',b);
