function varargout = robot(varargin)
% ROBOT MATLAB code for robot.fig
%      ROBOT, by itself, creates a new ROBOT or raises the existing
%      singleton*.
%
%      H = ROBOT returns the handle to a new ROBOT or the handle to
%      the existing singleton*.
%
%      ROBOT('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in ROBOT.M with the given input arguments.
%
%      ROBOT('Property','Value',...) creates a new ROBOT or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before robot_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to robot_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help robot

% Last Modified by GUIDE v2.5 10-Jun-2022 04:39:35

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @robot_OpeningFcn, ...
                   'gui_OutputFcn',  @robot_OutputFcn, ...
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


% --- Executes just before robot is made visible.
function robot_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to robot (see VARARGIN)

% Choose default command line output for robot
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes robot wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = robot_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on slider movement.
function slider1_Callback(hObject, eventdata, handles)
verii1=get(handles.slider1,'Value');
set(handles.text1,'String',verii1);
veri1=verii1;

assignin('base','veri1',veri1);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');


% hObject    handle to slider1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end



function edit1_Callback(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit1 as text
%        str2double(get(hObject,'String')) returns contents of edit1 as a double


% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on slider movement.
function slider2_Callback(hObject, eventdata, handles)
verii2=get(handles.slider2,'Value');
set(handles.text2,'String',verii2);
veri2=verii2;

assignin('base','veri2',veri2);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');
% hObject    handle to slider2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function slider3_Callback(hObject, eventdata, handles)
verii3=get(handles.slider3,'Value');
set(handles.text3,'String',verii3);
veri3=verii3;

assignin('base','veri3',veri3);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');
% hObject    handle to slider3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function slider4_Callback(hObject, eventdata, handles)
verii4=get(handles.slider4,'Value');
set(handles.text4,'String',verii4);
veri4=verii4;

assignin('base','veri4',veri4);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');
% hObject    handle to slider4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider4_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function slider5_Callback(hObject, eventdata, handles)
verii5=get(handles.slider5,'Value');
set(handles.text5,'String',verii5);
veri5=verii5;

assignin('base','veri5',veri5);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');
% hObject    handle to slider5 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider5_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider5 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function slider6_Callback(hObject, eventdata, handles)
verii6=get(handles.slider6,'Value');
set(handles.text6,'String',verii6);
veri6=verii6;

assignin('base','veri6',veri6);
load_system('KUKAKR_5R850');
find_system('Name','KUKAKR_5R850');
open_system('KUKAKR_5R850');

sim('KUKAKR_5R850');
% hObject    handle to slider6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider


% --- Executes during object creation, after setting all properties.
function slider6_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes during object creation, after setting all properties.
function textx_CreateFcn(hObject, eventdata, handles)

  

% hObject    handle to textx (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes during object creation, after setting all properties.
function texty_CreateFcn(hObject, eventdata, handles)

% hObject    handle to texty (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes during object creation, after setting all properties.
function textz_CreateFcn(hObject, eventdata, handles)


% hObject    handle to textz (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
verii1=str2num(verii1);
verii2=str2num(verii2);
verii3=str2num(verii3);
verii4=str2num(verii4);
verii5=str2num(verii5);
verii6=str2num(verii6);

teta1=verii1;
teta2=verii2;
teta3=verii3;
teta4=verii4;
teta5=verii5;
teta6=verii6;

teta_1=deg2rad(teta1);
teta_2=deg2rad(teta2);
teta_3=deg2rad(teta3);
teta_4=deg2rad(teta4);
teta_5=deg2rad(teta5);
teta_6=deg2rad(teta6);

alpha1=   0;
alpha2=   -90;
alpha3=   0;
alpha4=   -90;
alpha5=   90;
alpha6=   -90;

alpha_1=deg2rad(alpha1);
alpha_2=deg2rad(alpha2);
alpha_3=deg2rad(alpha3);
alpha_4=deg2rad(alpha4);
alpha_5=deg2rad(alpha5);
alpha_6=deg2rad(alpha6);

a_1= 0;
a_2= 75;
a_3= 355;
a_4= 90;
a_5= 0;
a_6= 0;

d_1= 331;  
d_2= 2;    
d_3= 0;
d_4= 320; %404;   
d_5= 0;
d_6= 0;

%syms teta_1  teta_2 teta_3 teta_4 teta_5 teta_6 ;

T_01=[ cos(teta_1)                      -sin(teta_1)                   0                       a_1 
       sin(teta_1)*cos(alpha_1)   cos(teta_1)*cos(alpha_1)       -sin(alpha_1)       -sin(alpha_1)*d_1  
       sin(teta_1)*sin(alpha_1)   cos(teta_1)*sin(alpha_1)        cos(alpha_1)        cos(alpha_1)*d_1  
             0                            0                       0             1                ];
         
         
T_12=[ cos(-pi/2+teta_2)                      -sin(-pi/2+teta_2)                   0                       a_2 
       sin(-pi/2+teta_2)*cos(alpha_2)   cos(-pi/2+teta_2)*cos(alpha_2)       -sin(alpha_2)       -sin(alpha_2)*d_2 
       sin(-pi/2+teta_2)*sin(alpha_2)   cos(-pi/2+teta_2)*sin(alpha_2)        cos(alpha_2)        cos(alpha_2)*d_2   
             0                            0                       0             1                ];         
         
            
T_23=[ cos(teta_3)                      -sin(teta_3)                   0                       a_3
       sin(teta_3)*cos(alpha_3)   cos(teta_3)*cos(alpha_3)       -sin(alpha_3)       -sin(alpha_3)*d_3  
       sin(teta_3)*sin(alpha_3)   cos(teta_3)*sin(alpha_3)        cos(alpha_3)        cos(alpha_3)*d_3   
             0                            0                       0             1                ];   
         
T_34=[ cos(teta_4)                      -sin(teta_4)                   0                       a_4
       sin(teta_4)*cos(alpha_4)   cos(teta_4)*cos(alpha_4)       -sin(alpha_4)       -sin(alpha_4)*d_4  
       sin(teta_4)*sin(alpha_4)   cos(teta_4)*sin(alpha_4)        cos(alpha_4)        cos(alpha_4)*d_4   
             0                            0                       0             1                ];        
         
T_45=[ cos(teta_5)                      -sin(teta_5)                   0                       a_5
       sin(teta_5)*cos(alpha_5)   cos(teta_5)*cos(alpha_5)       -sin(alpha_5)       -sin(alpha_5)*d_5  
       sin(teta_5)*sin(alpha_5)   cos(teta_5)*sin(alpha_5)        cos(alpha_5)        cos(alpha_5)*d_5   
             0                            0                       0                     1                ];  
         
         
T_56=[ cos(teta_6)                      -sin(teta_6)                   0                       a_6
       sin(teta_6)*cos(alpha_6)   cos(teta_6)*cos(alpha_6)       -sin(alpha_6)       -sin(alpha_6)*d_6  
       sin(teta_6)*sin(alpha_6)   cos(teta_6)*sin(alpha_6)        cos(alpha_6)        cos(alpha_6)*d_6   
             0                            0                       0                     1                ];          
         
T_06= T_01*T_12*T_23*T_34*T_45*T_56;

%    x=T_06(1,4);
%    y=T_06(2,4);
%    z=T_06(3,4);
  
  R_06=[T_06(1,1) T_06(1,2) T_06(1,3)
      T_06(2,1) T_06(2,2) T_06(2,3)
      T_06(3,1) T_06(3,2) T_06(3,3)];

A=R_06*86;
B=[0
   0
   1];
A1=A*B;
    
%   x=T_06(1,4)+A1(1,1);
%   y=T_06(2,4)+A1(2,1);
  z=T_06(3,4)+A1(3,1);
  set(handles.textz,'String',z);

% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
