using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WordsOfUnraveling : Template
    {
        public static readonly Guid ID = Guid.Parse("91ddf5ff-cc6b-4f54-ac45-e6dbb4ffb3ee");

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
            yield return new TextBlock { Id = Guid.Parse("d1dcf1d7-ee73-46d0-a460-7e5364c9c71d"), Type = TextBlockType.Text, Text = "You have unlocked abstruse methods to tangle with reality itself, altering the fate of a single individual. Once per day as an occult innate spell, you can cast (spell: daydreamer&#39;s curse), (spell: outcast&#39;s curse), or (spell: savant&#39;s curse). At the GM&#39;s discretion, you can substitute or add additional occult (trait: curse) spells of 4th level or lower to this list. You can choose a different spell from the list each time you use this ability." };
            yield return new TextBlock { Id = Guid.Parse("85eec667-5c6b-4395-992d-f557c3a680a3"), Type = TextBlockType.Text, Text = "If you couldn&#39;t already cast occult spells, these spells use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for occult spells; if you could already cast occult spells, your proficiency in spell attack rolls and spell DCs for occult spells increases to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3334a7d5-7438-41d1-964e-a7e1ee7e44d7"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("534dca17-6c90-4370-b25b-321d047d6a1f"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
