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
    public class ProtectiveSheath : Template
    {
        public static readonly Guid ID = Guid.Parse("a6c1053c-68fc-4a70-b9d3-f25917bb2674");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protective Sheath",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fec88c4a-90e9-45fd-ae68-a7def84adcce"), Type = TextBlockType.Text, Text = $"When you lash out with your {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("clan dagger", Items.MeleeWeapons.Instances.ClanDagger.ID)}, you keep its sheath close at hand. When you use {ToMarkdownLink<Models.Entities.Feat>("Clan's Edge", Feats.Instances.ClansEdge.ID)}, if the hand you're not holding the dagger with is empty, you can use your clan dagger's sheath to block attacks as well. The circumstance bonus to your AC from parrying increases to a +2 against any target you hit with a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1b4e5030-6e19-4984-af8d-51b86ae0ea59"), Feats.Instances.ClansEdge.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fa0275e0-f828-4663-91c6-25374f1b51f9"), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db4628d5-7bcb-405d-a1dd-28e4b4efd609"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
