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
    public class WidenTheGap : Template
    {
        public static readonly Guid ID = Guid.Parse("29ae016a-7630-4fce-b21a-c3a352cd0e70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Widen the Gap",
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
            yield return new TextBlock { Id = Guid.Parse("128c9471-2d37-4d0d-987d-4d12f6174bbf"), Type = TextBlockType.Text, Text = $"Once you have penetrated a foe's defenses, you can home in on the same spot to exploit your opponent's wound and deal some serious damage. The second time you hit and deal damage with a melee axe {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} to the same opponent or object during your turn, you ignore half of the opponent's or object's Hardness, if any. If you hit and deal damage with a melee axe {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} to the same opponent or object a third or fourth time during your turn, you ignore all of its Hardness, if any." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d2dd1d6a-8557-401f-ad67-552141d23570"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("140e5d3c-6214-4a9b-8f46-9674a7393e62"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
