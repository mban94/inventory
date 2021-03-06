﻿DROP FUNCTION IF EXISTS inventory.get_inventory_account_id(_item_id integer);

CREATE FUNCTION inventory.get_inventory_account_id(_item_id integer)
RETURNS integer
AS
$$
BEGIN
    RETURN
        inventory_account_id
    FROM inventory.item_groups
    INNER JOIN inventory.items
    ON inventory.item_groups.item_group_id = inventory.items.item_group_id
    WHERE inventory.items.item_id = $1
	AND NOT inventory.item_groups.deleted;    
END
$$
LANGUAGE plpgsql;
