using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DousingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("76a17456-3e9d-438b-bb41-a3906d19e531");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dousing Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("868327ee-6c52-4387-a448-a1c3465dce83"), Type = TextBlockType.Text, Text = "You enhance your spell with elemental water, soaking the target. If the next action you use is to Cast a Spell targeting a single creature, you soak the target of the spell with water. If the target has persistent acid or fire damage, the DC to end those conditions is reduced to 10, and the creature can attempt a flat check to end those types of persistent damage immediately. The spell gains the (trait: water) trait (causing it to deal extra damage to creatures with weakness to water)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b9251d85-7d41-42ab-a108-df4a23980c5f"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6049fc95-5f98-4703-9193-7042eaf12f61"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
