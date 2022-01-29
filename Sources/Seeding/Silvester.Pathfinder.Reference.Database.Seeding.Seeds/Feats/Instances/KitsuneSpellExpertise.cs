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
    public class KitsuneSpellExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("2a1a31a6-4615-40b1-84c7-724ff6bda310");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4d5fc26-5e2e-4943-a7c3-d68afc3c81ef"), Type = TextBlockType.Text, Text = $"Your tails show your magical mastery. During your daily preparations, choose {ToMarkdownLink<Models.Entities.Spell>("confusion", Spells.Instances.Confusion.ID)}, {ToMarkdownLink<Models.Entities.Spell>("death ward", Spells.Instances.DeathWard.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("illusory scene", Spells.Instances.IllusoryScene.ID)}. You can {ToMarkdownLink<Models.Entities.Rule>("Cast this Spell", Rules.Instances.CastASpell.ID)} as a 5th-level divine innate spell once that day. You become an expert in divine spell DCs and divine spell attack rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("85d974e8-dae8-4705-bd30-326f21d3d1e5"), Feats.Instances.KitsuneSpellMysteries.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fc616c46-ee46-477b-a3ac-1b58b6b9417f"), Traits.Instances.Kitsune.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0df296ae-1ecf-4046-9bf3-386cecac04a2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
