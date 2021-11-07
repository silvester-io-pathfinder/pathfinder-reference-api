using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmbedAeonStone : Template
    {
        public static readonly Guid ID = Guid.Parse("d2cb9d48-a031-44fa-9e91-644495125004");

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
            yield return new TextBlock { Id = Guid.Parse("f7ebf05f-c1b3-4d97-8b6b-acbb0f1d3d04"), Type = TextBlockType.Text, Text = "You discover the secrets to embedding aeon stones into your flesh. You spend 1 day attuning to an aeon stone and physically embedding it in your skin. While the stone is embedded this way, you gain the benefits of the aeon stone as if it were orbiting above your head, but it protects the stone from being noticed or stolen as easily. Aeon stones in your flesh must be invested to function, as usual." };
            yield return new TextBlock { Id = Guid.Parse("965c5844-06de-41b8-ae30-a94dc05596bf"), Type = TextBlockType.Text, Text = "You can also use this activity to safely remove an embedded aeon stone in 1 day. Someone without this feat can attempt to surgically remove it safely by spending 1 day and succeeding at a DC 30 Medicine check, or hastily by simply ripping it from a corpse" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ed0ad53b-a381-423d-a50f-6c70be06ec1c"), Feats.Instances.RunelordDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9f09c8fe-6839-465c-adc0-41c484ba3f2f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("522fd3f2-3432-4683-9387-7beba92957d7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
