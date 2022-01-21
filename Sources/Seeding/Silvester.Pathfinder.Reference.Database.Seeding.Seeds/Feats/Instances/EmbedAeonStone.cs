using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmbedAeonStone : Template
    {
        public static readonly Guid ID = Guid.Parse("a3570bf4-73da-49bf-b84a-2817024d9ed7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Embed Aeon Stone",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7ae0b2e-72be-48d3-88af-4de7a1a5182b"), Type = TextBlockType.Text, Text = $"You discover the secrets to embedding aeon stones into your flesh. You spend 1 day attuning to an aeon stone and physically embedding it in your skin. While the stone is embedded this way, you gain the benefits of the aeon stone as if it were orbiting above your head, but it protects the stone from being noticed or stolen as easily. Aeon stones in your flesh must be invested to function, as usual." };
            yield return new TextBlock { Id = Guid.Parse("a1537251-cc02-4cc4-88ff-0c9ce28cdfa0"), Type = TextBlockType.Text, Text = $"You can also use this activity to safely remove an embedded aeon stone in 1 day. Someone without this feat can attempt to surgically remove it safely by spending 1 day and succeeding at a DC 30 Medicine check, or hastily by simply ripping it from a corpse" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("908662ef-bc21-4279-89ca-bb45c3e8fd02"), Feats.Instances.RunelordDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d5fc80bb-d57e-460a-a53f-6514d790a045"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("875feec3-165b-40d2-94fe-60dcb753e27c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
