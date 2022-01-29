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
    public class ImposingDestrier : Template
    {
        public static readonly Guid ID = Guid.Parse("67cf9c34-60af-45b8-988b-2960baed7b99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Imposing Destrier",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("911e8b97-f50d-4cd1-ac2b-a290973e2e17"), Type = TextBlockType.Text, Text = $"Under your care, your mount has realized its innate potential. The mount you gained through the divine ally class feature is now a nimble or savage animal companion (page 214). During an encounter, even if you don't use the {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} action, your mount can still use 1 action on your turn to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} or {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("02691faf-7c3e-40ca-9019-668c39fc24bd"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificFeat(Guid.Parse("2994d31b-e880-4a8d-8ee7-824c332ec0d0"), Feats.Instances.LoyalWarhorse.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bea82ba5-9e07-46d3-bf12-78ea25008bb1"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83d5db6e-69ec-4e40-9ec9-2723687ffa64"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
