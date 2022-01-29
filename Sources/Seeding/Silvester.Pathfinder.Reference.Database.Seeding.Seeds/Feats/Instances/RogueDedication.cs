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
    public class RogueDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ccf1fa9f-a86b-48df-93ca-0ce4eb125153");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rogue Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot gain another dedication feat until you have gained two other feats from the rogue archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6600c03-b194-4b5f-b56e-c79855b88ff2"), Type = TextBlockType.Text, Text = $"You gain a skill feat and the rogue's surprise attack class feature (page 181). You become trained in light armor. In addition, you become trained in Stealth or Thievery plus one skill of your choice; if you are already trained in both Stealth and Thievery, you become trained in an additional skill of your choice. You become trained in rogue class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("86928f4f-044c-4ee8-a2fe-0af2caf4701f"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1cdc78e2-b826-4e3f-8aef-50234410e3cb"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("4d82632b-0c37-4e36-aa87-b9fb74dc351d"), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse("82c3164d-9348-4817-899e-dcc24737131e"), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8791fdf2-0a9f-4242-a30d-5cbe3c87d4fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
