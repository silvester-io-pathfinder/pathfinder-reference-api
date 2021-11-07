using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantBladeSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("58b35ccf-edc6-4379-a9c3-aa1a9b7284d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Blade Spirit",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb0e7160-6693-4b5c-9eac-bc98c2c53e7a"), Type = TextBlockType.Text, Text = "Your divine ally radiates power, enhancing your chosen weapon. When you choose the weapon for your blade ally during your daily preparations, add the following property runes to the list of effects you can choose from: (item: flaming | Flaming Runestone) and any aligned properties ((item: anarchic | Anarchic Runestone), (item: axiomatic | Axiomatic Runestone), (item: holy | Holy Runestone), or (item: unholy | Unholy Runestone)) that match your cause’s alignment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("014febda-d7ac-45d0-bd74-ef5591f9942c"), DivineAllies.Instances.Blade.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("867701ed-4287-4e54-9d3a-85ecf26c7309"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
