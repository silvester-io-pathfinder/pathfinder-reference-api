using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StellasStabAndSnag : Template
    {
        public static readonly Guid ID = Guid.Parse("62e7f432-4931-4cc8-940e-9d7cde8761fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stella's Stab and Snag",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("973caf66-9199-4cb8-a708-0dc48cb86af8"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("6d2eb169-16ff-4bb3-9edd-4f25e87ea841"), Type = TextBlockType.Text, Text = "You dart towards your opponent, seeking to stab them and slice their purse-strings with a single movement. (action: Stride) up to your Speed; this movement does not trigger reactions triggered by movement. At any point during this movement you can (action: Strike) an opponent within reach. If this (action: Strike) is successful, you can attempt a Thievery check to (action: Steal) from the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d7e843c3-ee04-406a-92e3-204ae07a4eb1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b99c237-b590-4415-afa9-9e7aca839015"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
