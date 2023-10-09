function varargout = untitled(varargin)
% UNTITLED MATLAB code for untitled.fig
%      UNTITLED, by itself, creates a new UNTITLED or raises the existing
%      singleton*.
%
%      H = UNTITLED returns the handle to a new UNTITLED or the handle to
%      the existing singleton*.
%
%      UNTITLED('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in UNTITLED.M with the given input arguments.
%
%      UNTITLED('Property','Value',...) creates a new UNTITLED or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before untitled_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to untitled_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help untitled

% Last Modified by GUIDE v2.5 10-Jun-2022 05:43:26

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @untitled_OpeningFcn, ...
                   'gui_OutputFcn',  @untitled_OutputFcn, ...
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
% End initialization code - DO NOT EDIT


% --- Executes just before untitled is made visible.
function untitled_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to untitled (see VARARGIN)

% Choose default command line output for untitled
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes untitled wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = untitled_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
axes(handles.axes1);
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_1=0;
tf_1=2;

q_0_1=30;
q_f_1=90;

q_dot0_1=0;
q_dotf_1=0;

q_ddot0_1=10;
q_ddotf_1=10;

s0_1=q_0_1;
s1_1=q_dot0_1;
s2_1=q_ddot0_1/2;
s3_1=((20*(q_f_1-q_0_1))-(8*q_dotf_1+12*q_dot0_1)*tf_1+(q_ddotf_1-3*q_ddot0_1)*tf_1.^2)/(2*tf_1.^3);
s4_1=(30*(q_0_1-q_f_1)+(14*q_dotf_1+16*q_dot0_1)*tf_1+(3*q_ddot0_1-2*q_ddotf_1)*tf_1.^2)/(2*tf_1.^4);
s5_1=(12*(q_f_1-q_0_1)-6*(q_dotf_1+q_dot0_1)*tf_1-(q_ddot0_1-q_ddotf_1)*tf_1.^2)/(2*tf_1.^5);

knm1=s0_1*+s1_1*(t)+s2_1*(t.^2)+s3_1*(t.^3)+s4_1*(t.^4)+s5_1*(t.^5);
hiz1=diff(knm1);
ivm1=diff(hiz1);

plot(t,knm1);

% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)
axes(handles.axes3);
syms t 
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_2=0;
tf_2=7;

q_0_2=70;
q_f_2=50;

q_dot0_2=0;
q_dotf_2=0;

q_ddot0_2=20;
q_ddotf_2=15;

s0_2=q_0_2;
s1_2=q_dot0_2;
s2_2=q_ddot0_2/2;
s3_2=((20*(q_f_2-q_0_2))-(8*q_dotf_2+12*q_dot0_2)*tf_2+(q_ddotf_2-3*q_ddot0_2)*tf_2.^2)/(2*tf_2.^3);
s4_2=(30*(q_0_2-q_f_2)+(14*q_dotf_2+16*q_dot0_2)*tf_2+(3*q_ddot0_2-2*q_ddotf_2)*tf_2.^2)/(2*tf_2.^4);
s5_2=(12*(q_f_2-q_0_2)-6*(q_dotf_2+q_dot0_2)*tf_2-(q_ddot0_2-q_ddotf_2)*tf_2.^2)/(2*tf_2.^5);

knm2=s0_2*+s1_2*(t)+s2_2*(t.^2)+s3_2*(t.^3)+s4_2*(t.^4)+s5_2*(t.^5);
hiz2=diff(knm2);
ivm2=diff(hiz2);
plot(t,knm2);



% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton3.
function pushbutton3_Callback(hObject, eventdata, handles)
axes(handles.axes4);
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_3=0;
tf_3=7;

q_0_3=70;
q_f_3=50;

q_dot0_3=0;
q_dotf_3=0;

q_ddot0_3=20;
q_ddotf_3=15;

s0_3=q_0_3;
s1_3=q_dot0_3;
s2_3=q_ddot0_3/2;
s3_3=((20*(q_f_3-q_0_3))-(8*q_dotf_3+12*q_dot0_3)*tf_3+(q_ddotf_3-3*q_ddot0_3)*tf_3.^2)/(2*tf_3.^3);
s4_3=(30*(q_0_3-q_f_3)+(14*q_dotf_3+16*q_dot0_3)*tf_3+(3*q_ddot0_3-2*q_ddotf_3)*tf_3.^2)/(2*tf_3.^4);
s5_3=(12*(q_f_3-q_0_3)-6*(q_dotf_3+q_dot0_3)*tf_3-(q_ddot0_3-q_ddotf_3)*tf_3.^2)/(2*tf_3.^5);

knm3=s0_3*+s1_3*(t)+s2_3*(t.^2)+s3_3*(t.^3)+s4_3*(t.^4)+s5_3*(t.^5);
hiz3=diff(knm3);
ivm3=diff(hiz3);
plot(t,knm3);


% hObject    handle to pushbutton3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton4.
function pushbutton4_Callback(hObject, eventdata, handles)
axes(handles.axes5);
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_4=0;
tf_4=20;

q_0_4=20;
q_f_4=30;

q_dot0_4=0;
q_dotf_4=0;

q_ddot0_4=8;
q_ddotf_4=8;

s0_4=q_0_4;
s1_4=q_dot0_4;
s2_4=q_ddot0_4/2;
s3_4=((20*(q_f_4-q_0_4))-(8*q_dotf_4+12*q_dot0_4)*tf_4+(q_ddotf_4-3*q_ddot0_4)*tf_4.^2)/(2*tf_4.^3);
s4_4=(30*(q_0_4-q_f_4)+(14*q_dotf_4+16*q_dot0_4)*tf_4+(3*q_ddot0_4-2*q_ddotf_4)*tf_4.^2)/(2*tf_4.^4);
s5_4=(12*(q_f_4-q_0_4)-6*(q_dotf_4+q_dot0_4)*tf_4-(q_ddot0_4-q_ddotf_4)*tf_4.^2)/(2*tf_4.^5);

knm4=s0_4*+s1_4*(t)+s2_4*(t.^2)+s3_4*(t.^3)+s4_4*(t.^4)+s5_4*(t.^5);
hiz4=diff(knm4);
ivm4=diff(hiz4);
plot(t,knm4);


% hObject    handle to pushbutton4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton5.
function pushbutton5_Callback(hObject, eventdata, handles)
axes(handles.axes6);
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_5=0;
tf_5=20;

q_0_5=20;
q_f_5=30;

q_dot0_5=0;
q_dotf_5=0;

q_ddot0_5=8;
q_ddotf_5=8;

s0_5=q_0_5;
s1_5=q_dot0_5;
s2_5=q_ddot0_5/2;
s3_5=((20*(q_f_5-q_0_5))-(8*q_dotf_5+12*q_dot0_5)*tf_5+(q_ddotf_5-3*q_ddot0_5)*tf_5.^2)/(2*tf_5.^3);
s4_5=(30*(q_0_5-q_f_5)+(14*q_dotf_5+16*q_dot0_5)*tf_5+(3*q_ddot0_5-2*q_ddotf_5)*tf_5.^2)/(2*tf_5.^4);
s5_5=(12*(q_f_5-q_0_5)-6*(q_dotf_5+q_dot0_5)*tf_5-(q_ddot0_5-q_ddotf_5)*tf_5.^2)/(2*tf_5.^5);

knm5=s0_5*+s1_5*(t)+s2_5*(t.^2)+s3_5*(t.^3)+s4_5*(t.^4)+s5_5*(t.^5);
hiz5=diff(knm5);
ivm5=diff(hiz5);
plot(t,knm5);


% hObject    handle to pushbutton5 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in pushbutton6.
function pushbutton6_Callback(hObject, eventdata, handles)
axes(handles.axes7);
syms t 
t=[0 1 2 3 4 5 6 7 8 9 10];

t0_6=0;
tf_6=20;

q_0_6=20;
q_f_6=30;

q_dot0_6=0;
q_dotf_6=0;

q_ddot0_6=8;
q_ddotf_6=8;

s0_6=q_0_6;
s1_6=q_dot0_6;
s2_6=q_ddot0_6/2;
s3_6=((20*(q_f_6-q_0_6))-(8*q_dotf_6+12*q_dot0_6)*tf_6+(q_ddotf_6-3*q_ddot0_6)*tf_6.^2)/(2*tf_6.^3);
s4_6=(30*(q_0_6-q_f_6)+(14*q_dotf_6+16*q_dot0_6)*tf_6+(3*q_ddot0_6-2*q_ddotf_6)*tf_6.^2)/(2*tf_6.^4);
s5_6=(12*(q_f_6-q_0_6)-6*(q_dotf_6+q_dot0_6)*tf_6-(q_ddot0_6-q_ddotf_6)*tf_6.^2)/(2*tf_6.^5);

knm6=s0_6*+s1_6*(t)+s2_6*(t.^2)+s3_6*(t.^3)+s4_6*(t.^4)+s5_6*(t.^5);
hiz6=diff(knm6);
ivm6=diff(hiz6);
plot(t,knm6);

% hObject    handle to pushbutton6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
