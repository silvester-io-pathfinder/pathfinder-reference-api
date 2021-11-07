using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbsorbToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("629386e3-5da7-4ef7-b0db-af29829a4601");

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
            yield return new TextBlock { Id = Guid.Parse("ad2581f3-1f25-49c7-a8d7-42c64249437d"), Type = TextBlockType.Text, Text = "Your skin readily absorbs poison and can consciously draw toxins into your body to spare others. Attempt a counteract check against the triggering effect; your counteract level equals half your level (rounded up), and for the roll use either your class DC –10 or your spellcasting ability modifier plus your spellcasting proficiency bonus. If you counteract the triggering effect, you end the effect for all other creatures in the area; however, you must still save against the effect with a –2 penalty to the initial save." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("6deb18aa-18be-4aba-99e6-7dca3954679c"), "You are not immune to diseases or poisons.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c9a2886-c7fc-429d-b35d-6ba1443b95af"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
