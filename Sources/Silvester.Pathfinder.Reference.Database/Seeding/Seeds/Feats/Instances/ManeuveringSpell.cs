using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManeuveringSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("e87c7d08-b0e1-4f47-8875-bb01ed17b447");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Maneuvering Spell",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You begin to Cast a Spell that requires at least 2 actions to cast.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8de819ec-696d-4562-9999-44149796b203"), Type = TextBlockType.Text, Text = "You instantly tap into the magical power of a spell you&#39;re casting to quickly pounce around the battlefield. You (action: Step), (action: Leap), or (action: Stand | Stand / Drop Prone). This action can be before or after you (action: Cast the Spell | Cast a Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("77830ee5-2c6e-433a-87dd-371f0851b7c1"), Feats.Instances.SixthPillarDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd739950-10fa-4cf0-9be4-069bb6cdc47b"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
