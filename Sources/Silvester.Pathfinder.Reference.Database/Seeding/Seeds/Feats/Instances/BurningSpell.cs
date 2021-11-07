using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BurningSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("010a4570-1aa0-4ad3-8075-76748d7e2191");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Burning Spell",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fa0feda-c054-4f9d-a650-dece20e18f90"), Type = TextBlockType.Text, Text = "You enhance your spell with elemental fire, causing it to set the target on fire. If the next action you use is to (action: Cast a non-cantrip Spell | Cast a Spell) that deals damage at a single target, the spell deals additional persistent fire damage equal to the spell level, in addition to its other effects. This has no effect if the spell already deals persistent fire damage. The spell gains the (trait: fire) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("00c9727e-b621-49b2-99a1-3c6dc3815107"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b7341ca-d109-401c-b956-a25dc998f12e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
