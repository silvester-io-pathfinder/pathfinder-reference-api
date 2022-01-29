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
    public class RunescarredDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d0c93897-10db-4439-9890-d793e842f6b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runescarred Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the runescarred archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68f36e19-6604-41ef-9ec7-efc27e41343b"), Type = TextBlockType.Text, Text = $"~ Access: You are from the Saga Lands." };
            yield return new TextBlock { Id = Guid.Parse("087a9536-38e6-4fa3-b2a3-7e7a94695e4a"), Type = TextBlockType.Text, Text = $"Whether through blood (if you're Varisian, Shoanti, or New Thassilonian) or by exposure to rune magic, you have become runescarred, with visible, glowing runes on your body in the form of tattoos or scars. You might have possessed these marks before gaining the archetype, but you only truly became runescarred when you chose to study and tap into the runes' power. You become an expert in Arcana and you also become trained in Thassilon Lore, or an expert in Thassilon Lore if you were already trained in it." };
            yield return new TextBlock { Id = Guid.Parse("09baa92e-9435-4b6c-ae33-c21354fe23e3"), Type = TextBlockType.Text, Text = $"Choose one cantrip from the arcane list. One of the runes on your body corresponds to the chosen cantrip, and you can cast the chosen cantrip as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0a710ea6-f4c3-4613-88f2-912cc5fc3799"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f6d2d8a0-3a6e-4639-9358-af69aee006f9"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("d3e0e9bb-a910-4996-b7bf-75c6948a254d"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acbef6c2-dc83-4018-912f-31dc630927af"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
