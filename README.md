# Hair Salon Pricing Application

This application is designed to determine the total cost of hair salon services based on user input through a graphical user interface (GUI). The user can select a hairdresser and one or more services, and the application will calculate the total price based on predefined rates.

## Features

### 1. **Hairdresser Selection**
   - **ComboBox (DropDownList)** to select a hairdresser.
   - Each hairdresser has a different base rate:
     - **Jane** - $30
     - **Pat** - $45
     - **Ron** - $40
     - **Sue** - $50
     - **Laurie** - $55

### 2. **Service Selection**
   - **ListBox** to select one or more services.
   - Each service has a different rate:
     - **Cut** - $30
     - **Wash, blow-dry, and style** - $20
     - **Colour** - $40
     - **Highlights** - $50
     - **Extension** - $200
     - **Up-do** - $60

### 3. **Add Service Button**
   - Adds the selected hairdresser and services to the **Charged Items ListBox**.
   - Corresponding prices are displayed in the **Price ListBox**.
   - The **Add Service** button should only add the selected service. The hairdresser will be added the first time this button is used.

### 4. **Calculate Total Price Button**
   - Displays the total cost of all items in the **Price ListBox** in currency format.
   - Enabled after the **Add Service** button has been used for the first time.

### 5. **Reset Button**
   - Resets the entire form:
     - Selects the first hairdresser in the **ComboBox**.
     - Clears the **Charged Items ListBox** and the **Price ListBox**.
     - Clears the **Total Price Label**.
     - Disables the **Add Service** and **Calculate Total Price** buttons.
     - Sets focus to the **Hairdresser ComboBox**.

### 6. **Control State Management**
   - Initially, the **Add Service** and **Calculate Total Price** buttons are disabled.
   - **Add Service** button is enabled only after a service is selected.
   - **Calculate Total Price** button is enabled only after the **Add Service** button has been used for the first time.
   - The **Hairdresser ComboBox** is disabled once the **Add Service** button is used for the first time.

---

## How It Works

1. **Select a Hairdresser:**
   - Choose one hairdresser from the ComboBox. Each hairdresser has a different base rate, which will be added to the **Charged Items ListBox** when the **Add Service** button is clicked.

2. **Select One or More Services:**
   - Choose one or more services from the **ListBox**. Each selected service will have a price that will appear in the **Price ListBox** when the **Add Service** button is clicked.

3. **Add Service Button:**
   - This button will display the selected hairdresser and services in the **Charged Items ListBox**.
   - Corresponding prices will appear in the **Price ListBox**.
   - The button should be disabled until a service is selected.

4. **Calculate Total Price Button:**
   - After using the **Add Service** button, the **Calculate Total Price** button becomes enabled.
   - When clicked, it will calculate the total price of all services and display the result in currency format in the **Total Price Label**.

5. **Reset Button:**
   - Resets the form to its initial state, enabling the **Hairdresser ComboBox** and disabling the **Add Service** and **Calculate Total Price** buttons.

---

## Controls and Their Behavior

- **Hairdresser ComboBox:**
   - Initially enabled. After the **Add Service** button is clicked for the first time, it will be disabled.

- **Service ListBox:**
   - Allows selection of one or more services.
   - The **Add Service** button is enabled only after a service is selected.

- **Add Service Button:**
   - Initially disabled.
   - Enabled after a service is selected. It adds the selected hairdresser and services to the **Charged Items ListBox** and their corresponding prices to the **Price ListBox**.

- **Calculate Total Price Button:**
   - Initially disabled.
   - Enabled after the **Add Service** button has been used.

- **Reset Button:**
   - Resets the form, clears all selected items and prices, and disables the **Add Service** and **Calculate Total Price** buttons.

---

## Example Flow

1. **Step 1**: Select a hairdresser from the ComboBox (e.g., "Jane").
2. **Step 2**: Select one or more services from the ListBox (e.g., "Cut" and "Wash, blow-dry, and style").
3. **Step 3**: Click the **Add Service** button to add the selected items and their prices to the list.
4. **Step 4**: Click the **Calculate Total Price** button to view the total price.
5. **Step 5**: If needed, click the **Reset** button to clear all selections and reset the form.

---

## Notes

- Ensure that controls are enabled/disabled appropriately to prevent erroneous selections.
- Use the `Enabled` property of controls to manage the flow of user actions.
