using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurreptitiousSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("166c686c-525c-4abe-88f7-f2628253807e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surreptitious Spellcaster",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31a5aa5a-6070-475f-a63f-3d841176f047"), Type = TextBlockType.Text, Text = "You’ve learned that it pays for a Pathfinder to be able to cast spells without being noticed. You gain the (feat: Conceal Spell) wizard class feat, though it’s not a wizard feat for you. You also gain a +2 circumstance bonus to Stealth checks to (feat: Conceal a Spell | Conceal Spell) and to Deception checks to conceal verbal components." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cb40cd2e-e829-46d4-90d4-8c7bc6138c84"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87202a16-b8a2-47eb-81b6-46f82a6e9649"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
