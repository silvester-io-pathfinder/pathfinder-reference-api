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
    public class Remediate : Template
    {
        public static readonly Guid ID = Guid.Parse("703dedd1-d99b-4e75-a315-3c9b7c74d06a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remediate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a90405e9-c8d2-4d4a-a773-02a560581239"), Type = TextBlockType.Text, Text = $"If your next action is to use your divine font to cast a 3-action {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell to damage creatures, you can harness the residual energy to counterbalance opposing forces. You use your {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell to attempt to counteract one effect in the spell's area with the chaotic, evil, good, or lawful trait. The chosen trait must oppose one component of your deity's alignment; if your deity is neutral, you can choose any one trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b9373ac9-b97a-415f-ae3e-c054f4c666e8"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("cc52837f-b6bf-4826-99f7-89a51bb9b855"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("1f44f6c7-e0d1-4abe-b375-45946c154a41"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a11007da-4321-49e3-99a0-7526d86f76ae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
