using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("59e75571-3d1d-4791-83b8-1da619c1f028");

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
            yield return new TextBlock { Id = Guid.Parse("3a0598d3-70b0-4600-af6b-a7e6a48eff0c"), Type = TextBlockType.Text, Text = $"As a Spellmaster, you are adept at identifying magic. You gain a +2 circumstance bonus when you {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} with a skill in which you are trained or better. If you have the {ToMarkdownLink<Models.Entities.Feat>("Wayfinder Resonance Tinkerer", Feats.Instances.WayfinderResonanceTinkerer.ID)} feat, you can change the cantrip you chose for that feat each day during your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("ee7d45b0-40a7-45b5-a64c-584c643d3b4d"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("8490cc93-8535-463e-b415-2c341b6ae278"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
                or.HaveSpecificStat(Guid.Parse("cfe01c3d-c1ee-410e-8f54-991ffe8ddfd0"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
                or.HaveSpecificStat(Guid.Parse("20f132d9-035b-4635-9585-e8bd19b1fcc8"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            });
            builder.HaveFocusPool(Guid.Parse("bf508203-ea35-4f0f-bf95-a3625b4936f7"));
            builder.Manual(Guid.Parse("b7b88685-0549-493d-b3f8-dbd6eafd4442"), "Member of the Pathfinder Society affiliated with the School of Spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e63a0e9-b8cd-4211-a0b0-ab090444e1bc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
