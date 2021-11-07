using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbsorbToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("afe81de9-2146-4c79-967d-a1193f854e3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Absorb Toxin",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a disease or poison effect that affects an area.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("310cd2c1-4a33-454d-adb8-90d0ff559279"), Type = TextBlockType.Text, Text = "Your skin readily absorbs poison and can consciously draw toxins into your body to spare others. Attempt a counteract check against the triggering effect; your counteract level equals half your level (rounded up), and for the roll use either your class DC –10 or your spellcasting ability modifier plus your spellcasting proficiency bonus. If you counteract the triggering effect, you end the effect for all other creatures in the area; however, you must still save against the effect with a –2 penalty to the initial save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("9add5a17-d67a-41ef-9fe3-75dabdb449a5"), "You are not immune to diseases or poisons.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc426e26-a162-47b1-a1a2-e70eded40e6f"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
