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
    public class WordsOfUnraveling : Template
    {
        public static readonly Guid ID = Guid.Parse("eea6f96b-488c-46db-a93e-b871fe11d7fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Words of Unraveling",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9ffc287-f806-4450-acee-cf35c262fda3"), Type = TextBlockType.Text, Text = $"You have unlocked abstruse methods to tangle with reality itself, altering the fate of a single individual. Once per day as an occult innate spell, you can cast {ToMarkdownLink<Models.Entities.Spell>("daydreamer's curse", Spells.Instances.DaydreamersCurse.ID)}, {ToMarkdownLink<Models.Entities.Spell>("outcast's curse", Spells.Instances.OutcastsCurse.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("savant's curse", Spells.Instances.SavantsCurse.ID)}. At the GM's discretion, you can substitute or add additional occult {ToMarkdownLink<Models.Entities.Trait>("curse", Traits.Instances.Curse.ID)} spells of 4th level or lower to this list. You can choose a different spell from the list each time you use this ability." };
            yield return new TextBlock { Id = Guid.Parse("e4331f72-b863-4ca8-8f75-9ab41ec9ce35"), Type = TextBlockType.Text, Text = $"If you couldn't already cast occult spells, these spells use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for occult spells; if you could already cast occult spells, your proficiency in spell attack rolls and spell DCs for occult spells increases to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d0496c97-5a7f-4af1-9665-0293c227bd50"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ca8c3b08-1f52-49d3-8f76-8528c0f46bdb"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc94a99a-05ef-4f0d-a5f8-d9e681c794cc"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
