﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    indexInAspx
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ShowBarang" runat="server">


    <div class="agile-tables">
					<div class="w3l-table-info">
					  <h2>Basic Implementation</h2>
					    <table id="table">
						<thead>
						  <tr>
							<th>Name</th>
							<th>Age</th>
							<th>Gender</th>
							<th>Height</th>
							<th>Province</th>
							<th>Sport</th>
						  </tr>
						</thead>
						<tbody>
						  <tr>
							<td>Jill Smith</td>
							<td>25</td>
							<td>Female</td>
							<td>5'4</td>
							<td>British Columbia</td>
							<td>Volleyball</td>
						  </tr>
						  <tr>
							<td>John Stone</td>
							<td>30</td>
							<td>Male</td>
							<td>5'9</td>
							<td>Ontario</td>
							<td>Badminton</td>
						  </tr>
						  <tr>
							<td>Jane Strip</td>
							<td>29</td>
							<td>Female</td>
							<td>5'6</td>
							<td>Manitoba</td>
							<td>Hockey</td>
						  </tr>
						  <tr>
							<td>Gary Mountain</td>
							<td>21</td>
							<td>Male</td>
							<td>5'8</td>
							<td>Alberta</td>
							<td>Curling</td>
						  </tr>
						  <tr>
							<td>James Camera</td>
							<td>31</td>
							<td>Male</td>
							<td>6'1</td>
							<td>British Columbia</td>
							<td>Hiking</td>
						  </tr>
						</tbody>
					  </table>
					</div>
				  <code class="js">
					$('#table').basictable();
				  </code>
		
				  <h3>Modifying Breakpoint</h3>
				  <table id="table-breakpoint">
					<thead>
					  <tr>
						<th>Name</th>
						<th>Age</th>
						<th>Gender</th>
						<th>Height</th>
						<th>Province</th>
						<th>Sport</th>
					  </tr>
					</thead>
					<tbody>
					  <tr>
						<td>Jill Smith</td>
						<td>25</td>
						<td>Female</td>
						<td>5'4</td>
						<td>British Columbia</td>
						<td>Volleyball</td>
					  </tr>
					  <tr>
						<td>John Stone</td>
						<td>30</td>
						<td>Male</td>
						<td>5'9</td>
						<td>Ontario</td>
						<td>Badminton</td>
					  </tr>
					  <tr>
						<td>Jane Strip</td>
						<td>29</td>
						<td>Female</td>
						<td>5'6</td>
						<td>Manitoba</td>
						<td>Hockey</td>
					  </tr>
					  <tr>
						<td>Gary Mountain</td>
						<td>21</td>
						<td>Male</td>
						<td>5'8</td>
						<td>Alberta</td>
						<td>Curling</td>
					  </tr>
					  <tr>
						<td>James Camera</td>
						<td>31</td>
						<td>Male</td>
						<td>6'1</td>
						<td>British Columbia</td>
						<td>Hiking</td>
					  </tr>
					</tbody>
				  </table>

				  <code class="js">
					$('#table-breakpoint').basictable({<br>
					&nbsp;&nbsp;&nbsp;&nbsp;breakpoint: 768,<br>
					});
				  </code>
			<!---728x90--->
				  <h3>Force Responsive Off</h3>

				 
				  <table id="table-force-off">
					<thead>
					  <tr>
						<th>Name</th>
						<th>Age</th>
						<th>Gender</th>
						<th>Height</th>
						<th>Province</th>
						<th>Sport</th>
					  </tr>
					</thead>
					<tbody>
					  <tr>
						<td>Jill Smith</td>
						<td>25</td>
						<td>Female</td>
						<td>5'4</td>
						<td>British Columbia</td>
						<td>Volleyball</td>
					  </tr>
					  <tr>
						<td>John Stone</td>
						<td>30</td>
						<td>Male</td>
						<td>5'9</td>
						<td>Ontario</td>
						<td>Badminton</td>
					  </tr>
					  <tr>
						<td>Jane Strip</td>
						<td>29</td>
						<td>Female</td>
						<td>5'6</td>
						<td>Manitoba</td>
						<td>Hockey</td>
					  </tr>
					  <tr>
						<td>Gary Mountain</td>
						<td>21</td>
						<td>Male</td>
						<td>5'8</td>
						<td>Alberta</td>
						<td>Curling</td>
					  </tr>
					  <tr>
						<td>James Camera</td>
						<td>31</td>
						<td>Male</td>
						<td>6'1</td>
						<td>British Columbia</td>
						<td>Hiking</td>
					  </tr>
					</tbody>
				  </table>

				  <code class="js">
					$('#table-force-off').basictable({<br>
					&nbsp;&nbsp;&nbsp;&nbsp;forceResponsive: false,<br>
					});
				  </code>

				  <h3>Max Height</h3>
				 <table id="table-max-height" class="max-height">
					<thead>
					  <tr>
						<th>Name</th>
						<th>Age</th>
						<th>Gender</th>
						<th>Height</th>
						<th>Province</th>
						<th>Sport</th>
					  </tr>
					</thead>
					<tbody>
					  <tr>
						<td>Jill Smith</td>
						<td>25</td>
						<td>Female</td>
						<td>5'4</td>
						<td>British Columbia</td>
						<td>Volleyball</td>
					  </tr>
					  <tr>
						<td>John Stone</td>
						<td>30</td>
						<td>Male</td>
						<td>5'9</td>
						<td>Ontario</td>
						<td>Badminton</td>
					  </tr>
					  <tr>
						<td>Jane Strip</td>
						<td>29</td>
						<td>Female</td>
						<td>5'6</td>
						<td>Manitoba</td>
						<td>Hockey</td>
					  </tr>
					  <tr>
						<td>Gary Mountain</td>
						<td>21</td>
						<td>Male</td>
						<td>5'8</td>
						<td>Alberta</td>
						<td>Curling</td>
					  </tr>
					  <tr>
						<td>James Camera</td>
						<td>31</td>
						<td>Male</td>
						<td>6'1</td>
						<td>British Columbia</td>
						<td>Hiking</td>
					  </tr>
					</tbody>
				  </table>

				  <code class="js">
					$('#table-max-height').basictable({<br>
					&nbsp;&nbsp;&nbsp;&nbsp;tableWrapper: true<br>
					});
				  </code>

				  <h3>Use Media Query Over JS Resize</h3>
				 
				  <table id="table-no-resize">
					<thead>
					  <tr>
						<th>Name</th>
						<th>Age</th>
						<th>Gender</th>
						<th>Height</th>
						<th>Province</th>
						<th>Sport</th>
					  </tr>
					</thead>
					<tbody>
					  <tr>
						<td>Jill Smith</td>
						<td>25</td>
						<td>Female</td>
						<td>5'4</td>
						<td>British Columbia</td>
						<td>Volleyball</td>
					  </tr>
					  <tr>
						<td>John Stone</td>
						<td>30</td>
						<td>Male</td>
						<td>5'9</td>
						<td>Ontario</td>
						<td>Badminton</td>
					  </tr>
					  <tr>
						<td>Jane Strip</td>
						<td>29</td>
						<td>Female</td>
						<td>5'6</td>
						<td>Manitoba</td>
						<td>Hockey</td>
					  </tr>
					  <tr>
						<td>Gary Mountain</td>
						<td>21</td>
						<td>Male</td>
						<td>5'8</td>
						<td>Alberta</td>
						<td>Curling</td>
					  </tr>
					  <tr>
						<td>James Camera</td>
						<td>31</td>
						<td>Male</td>
						<td>6'1</td>
						<td>British Columbia</td>
						<td>Hiking</td>
					  </tr>
					</tbody>
				  </table>

				  <code class="css">
					@media only screen and (max-width: 568px) {<br>
					&nbsp;&nbsp;#table-no-resize thead {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;display: none;<br>
					&nbsp;&nbsp;}<br><br>

					&nbsp;&nbsp;#table-no-resize tbody td {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;border: none !important;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;display: block;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;vertical-align: top;<br>
					&nbsp;&nbsp;}<br><br>

					&nbsp;&nbsp;#table-no-resize tbody td:before {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;content: attr(data-th) ": ";<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;display: inline-block;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;font-weight: bold;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;width: 6.5em;<br>
					&nbsp;&nbsp;}<br><br>

					&nbsp;&nbsp;#table-no-resize tbody td.bt-hide {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;display: none;<br>
					&nbsp;&nbsp;}<br>
					}
				  </code>

				  <code class="js">
					$('#table-no-resize').basictable({<br>
					&nbsp;&nbsp;&nbsp;&nbsp;noResize: true,<br>
					});
				  </code>

				  <h3>Two Axis Styling</h3>
				  <table id="table-two-axis" class="two-axis">
					<thead>
					  <tr>
						<th>Name</th>
						<th>Age</th>
						<th>Gender</th>
						<th>Height</th>
						<th>Province</th>
						<th>Sport</th>
					  </tr>
					</thead>
					<tbody>
					  <tr>
						<td>Jill Smith</td>
						<td>25</td>
						<td>Female</td>
						<td>5'4</td>
						<td>British Columbia</td>
						<td>Volleyball</td>
					  </tr>
					  <tr>
						<td>John Stone</td>
						<td>30</td>
						<td>Male</td>
						<td>5'9</td>
						<td>Ontario</td>
						<td>Badminton</td>
					  </tr>
					  <tr>
						<td>Jane Strip</td>
						<td>29</td>
						<td>Female</td>
						<td>5'6</td>
						<td>Manitoba</td>
						<td>Hockey</td>
					  </tr>
					  <tr>
						<td>Gary Mountain</td>
						<td>21</td>
						<td>Male</td>
						<td>5'8</td>
						<td>Alberta</td>
						<td>Curling</td>
					  </tr>
					  <tr>
						<td>James Camera</td>
						<td>31</td>
						<td>Male</td>
						<td>6'1</td>
						<td>British Columbia</td>
						<td>Hiking</td>
					  </tr>
					</tbody>
				  </table>

				  <code class="css w3agile-css">
					table.two-axis tr td:first-of-type {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;background: #dff1f7;<br>
					}<br><br>

					@media only screen and (max-width: 568px) {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;table.two-axis tr td:first-of-type,<br>
					&nbsp;&nbsp;&nbsp;&nbsp;table.two-axis tr:nth-of-type(2n+2) td:first-of-type,<br>
					&nbsp;&nbsp;&nbsp;&nbsp;table.two-axis tr td:first-of-type:before
					 {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;background: #dff1f7;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;color: #ffffff;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;}<br><br>

					&nbsp;&nbsp;&nbsp;&nbsp;table.two-axis tr td:first-of-type {<br>
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;border-bottom: 1px solid #e4ebeb;<br>
					&nbsp;&nbsp;&nbsp;&nbsp;}<br>
					}
				  </code>

				</div>
				<!-- //tables -->
			</div>


<div class="grid-form1">
  	<h3>Form Element</h3>
  	    <div class="tab-content">
		<div class="tab-pane active" id="horizontal-form">
			<form class="form-horizontal">
				<div class="form-group">
					<label for="focusedinput" class="col-sm-2 control-label">Focused Input</label>
					<div class="col-sm-8">
						<input type="text" class="form-control1" id="focusedinput" placeholder="Default Input">
					</div>
					<div class="col-sm-2">
						<p class="help-block">Your help text!</p>
					</div>
				</div>
				<div class="form-group">
					<label for="disabledinput" class="col-sm-2 control-label">Disabled Input</label>
					<div class="col-sm-8">
						<input disabled="" type="text" class="form-control1" id="disabledinput" placeholder="Disabled Input">
					</div>
				</div>
				<div class="form-group">
					<label for="inputPassword" class="col-sm-2 control-label">Password</label>
					<div class="col-sm-8">
						<input type="password" class="form-control1" id="inputPassword" placeholder="Password">
					</div>
				</div>
				<div class="form-group">
					<label for="checkbox" class="col-sm-2 control-label">Checkbox</label>
					<div class="col-sm-8">
						<div class="checkbox-inline1"><label><input type="checkbox"> Unchecked</label></div>
						<div class="checkbox-inline1"><label><input type="checkbox" checked=""> Checked</label></div>
						<div class="checkbox-inline1"><label><input type="checkbox" disabled=""> Disabled Unchecked</label></div>
						<div class="checkbox-inline1"><label><input type="checkbox" disabled="" checked=""> Disabled Checked</label></div>
					</div>
				</div>
				<div class="form-group">
					<label for="checkbox" class="col-sm-2 control-label">Checkbox Inline</label>
					<div class="col-sm-8">
						<div class="checkbox-inline"><label><input type="checkbox"> Unchecked</label></div>
						<div class="checkbox-inline"><label><input type="checkbox" checked=""> Checked</label></div>
						<div class="checkbox-inline"><label><input type="checkbox" disabled=""> Disabled Unchecked</label></div>
						<div class="checkbox-inline"><label><input type="checkbox" disabled="" checked=""> Disabled Checked</label></div>
					</div>
				</div>
				<div class="form-group">
					<label for="selector1" class="col-sm-2 control-label">Dropdown Select</label>
					<div class="col-sm-8"><select name="selector1" id="selector1" class="form-control1">
						<option>Lorem ipsum dolor sit amet.</option>
						<option>Dolore, ab unde modi est!</option>
						<option>Illum, fuga minus sit eaque.</option>
						<option>Consequatur ducimus maiores voluptatum minima.</option>
					</select></div>
				</div>
				<div class="form-group">
					<label class="col-sm-2 control-label">Multiple Select</label>
					<div class="col-sm-8">
						<select multiple="" class="form-control1">
							<option>Option 1</option>
							<option>Option 2</option>
							<option>Option 3</option>
							<option>Option 4</option>
							<option>Option 5</option>
						</select>
					</div>
				</div>
				<div class="form-group">
					<label for="txtarea1" class="col-sm-2 control-label">Textarea</label>
					<div class="col-sm-8"><textarea name="txtarea1" id="txtarea1" cols="50" rows="4" class="form-control1"></textarea></div>
				</div>
				<div class="form-group">
					<label for="radio" class="col-sm-2 control-label">Radio</label>
					<div class="col-sm-8">
						<div class="radio block"><label><input type="radio"> Unchecked</label></div>
						<div class="radio block"><label><input type="radio" checked=""> Checked</label></div>
						<div class="radio block"><label><input type="radio" disabled=""> Disabled Unchecked</label></div>
						<div class="radio block"><label><input type="radio" disabled="" checked=""> Disabled Checked</label></div>
					</div>
				</div>
				<div class="form-group">
					<label for="radio" class="col-sm-2 control-label">Radio Inline</label>
					<div class="col-sm-8">
						<div class="radio-inline"><label><input type="radio"> Unchecked</label></div>
						<div class="radio-inline"><label><input type="radio" checked=""> Checked</label></div>
						<div class="radio-inline"><label><input type="radio" disabled=""> Disabled Unchecked</label></div>
						<div class="radio-inline"><label><input type="radio" disabled="" checked=""> Disabled Checked</label></div>
					</div>
				</div>
				<div class="form-group">
					<label for="smallinput" class="col-sm-2 control-label label-input-sm">Small Input</label>
					<div class="col-sm-8">
						<input type="text" class="form-control1 input-sm" id="smallinput" placeholder="Small Input">
					</div>
				</div>
				<div class="form-group">
					<label for="mediuminput" class="col-sm-2 control-label">Medium Input</label>
					<div class="col-sm-8">
						<input type="text" class="form-control1" id="mediuminput" placeholder="Medium Input">
					</div>
				</div>
				<div class="form-group mb-n">
					<label for="largeinput" class="col-sm-2 control-label label-input-lg">Large Input</label>
					<div class="col-sm-8">
						<input type="text" class="form-control1 input-lg" id="largeinput" placeholder="Large Input">
					</div>
				</div>
			</form>
		</div>
	</div>
					
	<div class="bs-example" data-example-id="form-validation-states">    
            <form>
            <div class="form-group has-success">
            <label class="control-label" for="inputSuccess1">Input with success</label>
            <input type="text" class="form-control1" id="inputSuccess1">
            </div>
            <div class="form-group has-warning">
            <label class="control-label" for="inputWarning1">Input with warning</label>
            <input type="text" class="form-control1" id="inputWarning1">
            </div>
            <div class="form-group has-error">
            <label class="control-label" for="inputError1">Input with error</label>
            <input type="text" class="form-control1" id="inputError1">
            </div>
        </form>
    </div>
  <div class="panel-body">
	<form role="form" class="form-horizontal">
		<div class="form-group">
			<label class="col-md-2 control-label">Email Address</label>
			<div class="col-md-8">
				<div class="input-group">							
					<span class="input-group-addon">
						<i class="fa fa-envelope-o"></i>
					</span>
					<input type="text" class="form-control1" placeholder="Email Address">
				</div>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Password</label>
			<div class="col-md-8">
				<div class="input-group">
					<span class="input-group-addon">
						<i class="fa fa-key"></i>
					</span>
					<input type="password" class="form-control1" id="exampleInputPassword1" placeholder="Password">
				</div>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Email Address</label>
			<div class="col-md-8">
				<div class="input-group input-icon right">
					<span class="input-group-addon">
						<i class="fa fa-envelope-o"></i>
					</span>
					<input id="email" class="form-control1" type="text" placeholder="Email Address">
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">With tooltip</p>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Password</label>
			<div class="col-md-8">
				<div class="input-group input-icon right">
					<span class="input-group-addon">
						<i class="fa fa-key"></i>
					</span>
					<input type="password" class="form-control1" placeholder="Password">
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">With tooltip</p>
			</div>
		</div>
		<div class="form-group has-success">
			<label class="col-md-2 control-label">Input Addon Success</label>
			<div class="col-md-8">
				<div class="input-group input-icon right">
					<span class="input-group-addon">
						<i class="fa fa-envelope-o"></i>
					</span>
					<input id="email" class="form-control1" type="text" placeholder="Email Address">
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">Email is valid!</p>
			</div>
		</div>
		<div class="form-group has-error">
			<label class="col-md-2 control-label">Input Addon Error</label>
			<div class="col-md-8">
				<div class="input-group input-icon right">
					<span class="input-group-addon">
						<i class="fa fa-key"></i>
					</span>
					<input type="password" class="form-control1" placeholder="Password">
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">Error!</p>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Checkbox Addon</label>
			<div class="col-md-8">
				<div class="input-group">
					<div class="input-group-addon"><input type="checkbox"></div>
					<input type="text" class="form-control1">
				</div>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Checkbox Addon</label>
			<div class="col-md-8">
				<div class="input-group">
					<input type="text" class="form-control1">
					<div class="input-group-addon"><input type="checkbox"></div>
									
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">Checkbox on right</p>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Radio Addon</label>
			<div class="col-md-8">
				<div class="input-group">
					<div class="input-group-addon"><input type="radio"></div>
					<input type="text" class="form-control1">
				</div>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Radio Addon</label>
			<div class="col-md-8">
				<div class="input-group">
					<input type="text" class="form-control1">
					<div class="input-group-addon"><input type="radio"></div>
									
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">Radio on right</p>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Input Processing</label>
			<div class="col-md-8">
				<div class="input-icon right spinner">
					<i class="fa fa-fw fa-spin fa-spinner"></i>
					<input id="email" class="form-control1" type="text" placeholder="Processing...">
				</div>
			</div>
			<div class="col-sm-2">
				<p class="help-block">Processing right</p>
			</div>
		</div>
		<div class="form-group">
			<label class="col-md-2 control-label">Static Paragraph</label>
			<div class="col-md-8">
				<p class="form-control1 m-n">email@example.com</p>
			</div>
		</div>
		<div class="form-group mb-n">
			<label class="col-md-2 control-label">Readonly</label>
			<div class="col-md-8">
				<input type="text" class="form-control1" placeholder="Readonly" readonly="">
			</div>
		</div>
	</form>
	</div>
	<div class="bs-example" data-example-id="form-validation-states-with-icons">
    
    <form>
        <span id="inputGroupSuccess1Status" class="sr-only">(success)</span>
    </div>
          <div class="form-group">
            <label for="exampleInputFile">File input</label>
            <input type="file" id="exampleInputFile">
            <p class="help-block">Example block-level help text here.</p>
          </div>
          <div class="panel-footer">
		    <div class="row">
			    <div class="col-sm-8 col-sm-offset-2">
				    <button class="btn-primary btn">Submit</button>
				    <button class="btn-default btn">Cancel</button>
				    <button class="btn-inverse btn">Reset</button>
			    </div>
		    </div>
	     </div>             
    </form>
</div>
 	</div>
 	<!--//grid-->

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
