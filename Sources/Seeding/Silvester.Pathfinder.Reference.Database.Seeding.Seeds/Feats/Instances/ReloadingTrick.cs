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
    public class ReloadingTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("56c35b14-b5d6-40e7-bd82-62f3c76fc743");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reloading Trick",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Repeating Hand Crossbow Training) feat, you can use this feat with a (item: repeating hand crossbow) to load either a bolt or a magazine, but the speed means you can fire only one bolt, then the magazine jams. You must spend a 3-action (action: Interact) activity to remove the jammed magazine and clear it before it can be used again.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8287692a-1f12-4584-9d7f-cbd924dd8762"), Type = TextBlockType.Text, Text = $"You can fire off a single shot even when unprepared. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload your {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("hand crossbow", Items.RangedWeapons.Instances.HandCrossbow.ID)} and {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc585a22-76ee-4e71-bd5e-e9d85e65ec07"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("98e50e17-73c7-4cd1-bc5c-12edefed86be"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("f30c338d-c15f-49ff-a683-d52474e697b8"), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5de50a97-3b1d-4630-9f43-dcdd74aea240"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
