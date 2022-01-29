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
    public class BarbarianDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("002286ae-3b05-40e0-87bc-495573eb8852");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Barbarian Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the barbarian archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d2a8668-bc54-4818-9d1a-63c5874fb39d"), Type = TextBlockType.Text, Text = $"You become trained in Athletics; if you were already trained in Athletics, you instead become trained in a skill of your choice. You become trained in barbarian class DC." };
            yield return new TextBlock { Id = Guid.Parse("bb6168aa-a2bb-403a-b004-847a878aba81"), Type = TextBlockType.Text, Text = $"You can use the {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} action." };
            yield return new TextBlock { Id = Guid.Parse("0a92a1b4-f824-4be0-95e7-815b12a0f30e"), Type = TextBlockType.Text, Text = $"Choose an instinct as you would if you were a barbarian. You have that instinct for all purposes and become bound by its anathema, but you don't gain any of the other abilities it grants." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("25f786fb-5568-4cac-a152-534b860a3161"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("9be92ec8-db8a-4885-8d86-74b2c883127d"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5d7417c-475a-438f-ad43-93436841271a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
