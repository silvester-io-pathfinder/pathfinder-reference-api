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
    public class VehicleMechanicDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("763a84aa-faff-4a0f-93b4-826ca95a2f40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vehicle Mechanic Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the mechanic archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df641057-f1f2-43c0-a387-d47366ba7cf2"), Type = TextBlockType.Text, Text = $"You are adept at designing and maintaining mechanical vehicles, and you lavish your attention and ingenuity on one vehicle in particular. You become an expert in Crafting, and you choose one vehicle you own—or your party owns collectively—to be your signature vehicle: the vehicle you spend time customizing to grant it various advantages. You can spend 1 week of downtime with a new vehicle to designate it as your signature vehicle instead. Due to your amazing customizations and adjustments, pilots gain a +1 circumstance bonus to any piloting checks they make to control your signature vehicle. If you are a master in Crafting, this bonus increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("5922fdf8-a9f0-4c7c-adcf-502904d9eeac"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3717e194-c485-44c4-8296-304c94f94652"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
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
                Id = Guid.Parse("03cb0ee8-0392-4e4b-9fe7-cf14db01fdb1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
