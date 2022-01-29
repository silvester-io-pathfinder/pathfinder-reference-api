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
    public class PoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("2a9faeaa-ab52-4c54-a231-2ea17d496963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poison Weapon",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "During your daily preparations, you can prepare a number of simple injury poisons equal to your level. These poisons deal 1d4 poison damage. Only you can apply these poisons properly, and they expire the next time you prepare.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44703bd6-7d0d-4943-b63e-3ff6ca709944"), Type = TextBlockType.Text, Text = $"You apply a poison to the required weapon; if you have a free hand, you can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a poison as part of this action. If your next attack with that weapon before the end of your next turn hits and deals damage, it applies the effects of the poison, provided that poison can be delivered by {ToMarkdownLink<Models.Entities.Trait>("contact", Traits.Instances.Contact.ID)} or {ToMarkdownLink<Models.Entities.Trait>("injury", Traits.Instances.Injury.ID)}. If you critically fail the attack roll, the poison is wasted as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("01a2c8a0-4620-44b8-9061-3f09f15e7080"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05f40e3e-6e84-4a21-9e13-06daaf667551"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
