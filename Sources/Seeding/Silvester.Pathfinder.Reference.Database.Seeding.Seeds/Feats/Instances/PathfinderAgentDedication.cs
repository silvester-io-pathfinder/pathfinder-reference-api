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
    public class PathfinderAgentDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e072d9d7-7142-4ddd-9a6d-e619b5e76631");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pathfinder Agent Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Pathfinder agent archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84a04303-e316-4f60-8852-6a039944646b"), Type = TextBlockType.Text, Text = $"~ Access: You are from Absalom." };
            yield return new TextBlock { Id = Guid.Parse("04ca52ee-e149-4b7a-8352-874c2cb7ae89"), Type = TextBlockType.Text, Text = $"Your Pathfinder training has broadened your horizons and made you more flexible at various skills, since you never know when you might need an obscure skill to complete your mission. You become trained in one skill of your choice, or expert in a skill of your choice in which you were trained. You also become trained in Pathfinder Lore, or an expert if you were already trained. When using a skill untrained, your proficiency bonus is equal to your level instead of 0. You gain access to {ToMarkdownLink<Models.Items.Instances.WornItem>("wayfinders", Items.WornItems.Instances.Wayfinder.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("d6de089d-a8e7-4063-aed1-e6fa06269f90"), "Member of the Pathfinder Society");
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
                Id = Guid.Parse("2d58be7e-3cb9-4f53-92e3-4bb331e7d014"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
