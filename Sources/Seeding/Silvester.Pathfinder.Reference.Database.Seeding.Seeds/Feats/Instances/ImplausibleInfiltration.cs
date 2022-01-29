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
    public class ImplausibleInfiltration : Template
    {
        public static readonly Guid ID = Guid.Parse("49f4efdb-199c-4480-af97-195a52c28071");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implausible Infiltration",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eed6840d-6292-41cf-b902-341a044fa807"), Type = TextBlockType.Text, Text = $"You find tiny holes or imperfections that no one else could see and try to somehow fit yourself through them, possibly moving directly through the wall or floor from one side to the other. Your movement attempt fails if the wall or floor is made of something other than wood, plaster, or stone; is thicker than 10 feet; or contains even a thin layer of metal. If you have a climb Speed, you can use this ability to attempt to move through a ceiling." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2ee0e6e7-65e6-4089-8e8d-4c112029e75b"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificFeat(Guid.Parse("be263f2e-792b-49f4-9ca8-bf9609d29347"), Feats.Instances.QuickSqueeze.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5c6cc2c-1845-42d9-8a3d-9276f3c20d03"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
