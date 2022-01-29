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
    public class GreatBoaster : Template
    {
        public static readonly Guid ID = Guid.Parse("5ad297a7-f7a9-4488-a752-8384f5236127");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Great Boaster",
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
            yield return new TextBlock { Id = Guid.Parse("95b9e350-e31e-416a-86a8-0f83e36f134a"), Type = TextBlockType.Text, Text = $"Your bragging is particularly effective. If you succeed at a boast, you can attempt a great boast about that same skill by using your {ToMarkdownLink<Models.Entities.Feat>("Firebrand Braggart Dedication", Feats.Instances.FirebrandBraggartDedication.ID)} action about the same action during the duration of your original boast's circumstance bonus; this is an exception to the rule that you can't make another boast about the same action until your next daily preparations. A great boast uses the {ToMarkdownLink<Models.Entities.Feat>("Firebrand Braggart Dedication", Feats.Instances.FirebrandBraggartDedication.ID)} action, except that if you succeed, your circumstance bonus increases to +2 and remains for 1 hour. If you fail the great boast, you take a -2 circumstance penalty to attempt the same action for 4 hours. Once you declare a great boast about a particular action, you can't declare a great boast about the same action until the next time you make daily preparations, regardless of whether you succeed or fail at the check. The minimum challenging task for a great boast is one with at least a hard DC for your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("cc506b5d-7280-4d12-9446-3de09bdc1344"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
            builder.HaveSpecificFeat(Guid.Parse("7a7d354d-b453-4d00-b100-97c8061205fd"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("16aa21da-05be-438a-9270-7300efb2a3c6"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("163df3b0-ce9b-45b1-85ae-e18d2f7dab75"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
