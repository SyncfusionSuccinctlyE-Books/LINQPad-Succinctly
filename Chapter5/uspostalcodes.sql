CREATE TABLE states
(state_id INT IDENTITY NOT NULL,
 state_name VARCHAR(100) NOT NULL DEFAULT '',
 state_abbr VARCHAR(4) NOT NULL DEFAULT '');

ALTER TABLE states ADD CONSTRAINT pk_states PRIMARY KEY (state_id);
CREATE INDEX idx01_states ON states (state_name);

CREATE TABLE counties
(county_id INT IDENTITY NOT NULL,
 county_name VARCHAR(100) NOT NULL DEFAULT '',
 state_id INT NOT NULL DEFAULT 0);

ALTER TABLE counties ADD CONSTRAINT pk_counties PRIMARY KEY (county_id);
CREATE INDEX idx01_counties ON counties (county_name);
ALTER TABLE counties ADD CONSTRAINT fk01_counties FOREIGN KEY (state_id) REFERENCES states (state_id);

CREATE TABLE places
(
  place_id INT IDENTITY NOT NULL,
  place_name VARCHAR(200) NOT NULL DEFAULT '',
  postal_code CHAR(5) NOT NULL DEFAULT '',
  latitude DECIMAL(12,4) NOT NULL DEFAULT 0,
  longitude DECIMAL(12,4) NOT NULL DEFAULT 0,
  county_id INT NOT NULL DEFAULT 0
);

ALTER TABLE places ADD CONSTRAINT pk_places PRIMARY KEY (place_id);
CREATE INDEX idx01_places ON places (place_name);
ALTER TABLE places ADD CONSTRAINT fk01_places FOREIGN KEY (county_id) REFERENCES counties (county_id);
