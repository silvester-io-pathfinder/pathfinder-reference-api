using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstrumentOfSlaughter : Template
    {
        public static readonly Guid ID = Guid.Parse("b1a14c5d-30f8-45e4-b82c-d7435c99b673");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instrument of Slaughter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97e3ebb2-e3b7-4750-8ea2-ae6d72931d15"), Type = TextBlockType.Text, Text = "Your blade ally thirsts for the blood of your foes. Whenever you critically hit an enemy with the weapon inhabited by your blade ally while dealing extra damage from your champion’s reaction, the target takes persistent bleed damage equal to two of the weapon’s damage dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("5800cb27-2e5c-41df-aa4b-c0f12137bed9"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("a7a8dd0e-4f12-4aaf-b307-e672f092832a"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca3cf0be-fdc0-4715-87d2-e555312535f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
