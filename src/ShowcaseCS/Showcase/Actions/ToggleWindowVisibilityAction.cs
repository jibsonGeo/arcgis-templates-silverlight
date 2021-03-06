/*
Copyright 2013 Esri
Licensed under the Apache License, Version 2.0 (the "License");
You may not use this file except in compliance with the License.
You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Windows.Interactivity;

namespace ESRI.ArcGIS.SilverlightMapApp.Actions
{
	/// <summary>
	/// Toggles the IsOpen property of the <see cref="DraggableWindow"/>.
	/// </summary>
	public class ToggleWindowVisibilityAction : TargetedTriggerAction<DraggableWindow>
	{
		/// <summary>
		/// Invokes the action.
		/// </summary>
		/// <param name="parameter">The parameter to the action. If the Action 
		/// does not require a parameter, the parameter may be set to a null 
		/// reference.</param>
		protected override void Invoke(object parameter)
		{
			this.Target.IsOpen = !this.Target.IsOpen;
		}
	}
}
