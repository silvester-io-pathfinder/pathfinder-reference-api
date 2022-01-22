using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FarabellusFlip : Template
    {
        public static readonly Guid ID = Guid.Parse("dbd690fb-929f-41eb-ba9f-b502e463db67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Farabellus Flip",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy targets you with a melee Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79e3be7a-0929-4802-9786-6cc6409e096b"), Type = TextBlockType.Text, Text = $"~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("80d70be3-f76a-4f88-90f8-d294511fe240"), Type = TextBlockType.Text, Text = $"Surprisingly agile even in a breastplate and carrying a full rucksack, Marcos Farabellus developed this evasive maneuver during one of his many adventures. Flinging your body into a twisting somersault, you gain a +2 circumstance bonus to your AC against the triggering attack. If the attack still hits you, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} to an open space that's still within the triggering enemy's reach, turning the impact of the blow into momentum." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7016bc82-62c5-4b30-9336-a9fddc4602f1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("e272fd39-2028-4943-b228-9347ebb4cee0"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c271d4fe-1078-4178-9770-b3b09ab521ce"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
