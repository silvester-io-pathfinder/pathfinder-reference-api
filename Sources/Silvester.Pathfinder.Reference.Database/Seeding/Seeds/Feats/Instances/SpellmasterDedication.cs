using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("10675ca9-2aee-4d31-99c0-dab917773c3b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellmaster Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Spellmaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2351785a-4842-4a30-97f6-aeedcbab5e18"), Type = TextBlockType.Text, Text = "As a Spellmaster, you are adept at identifying magic. You gain a +2 circumstance bonus when you (action: Identify Magic) with a skill in which you are trained or better. If you have the (feat: Wayfinder Resonance Tinkerer) feat, you can change the cantrip you chose for that feat each day during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c332647c-e1ab-4774-ab63-4fc012b9edc4"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("a8070d0f-5285-4511-b8b7-5d0f5889cffc"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
                or.HaveSpecificStat(Guid.Parse("8bbe6056-7aa0-46e1-ac30-cc0f574d7e6c"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
                or.HaveSpecificStat(Guid.Parse("3ef44b4c-675a-43c2-86b9-0708016aab95"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            });
            builder.HaveFocusPool(Guid.Parse("ca4faf7c-7a3e-42de-b9dc-e408c00dae9f"));
            builder.Manual(Guid.Parse("7a8ac287-20fe-4ea8-bb6e-c5cc32c664b2"), "Member of the Pathfinder Society affiliated with the School of Spells.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e273f58-3eb3-41a2-b550-8a6893a078db"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
