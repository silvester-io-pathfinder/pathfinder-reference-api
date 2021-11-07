using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PathfinderAgentDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b0df6c62-864a-4855-a0bd-30cb5222edc0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pathfinder Agent Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Pathfinder agent archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6e367db-5bc4-4749-b25b-0fbdc3b0635e"), Type = TextBlockType.Text, Text = "~ Access: You are from Absalom." };
            yield return new TextBlock { Id = Guid.Parse("296f8f20-85a8-4e44-b639-58a77d4cd86e"), Type = TextBlockType.Text, Text = "Your Pathfinder training has broadened your horizons and made you more flexible at various skills, since you never know when you might need an obscure skill to complete your mission. You become trained in one skill of your choice, or expert in a skill of your choice in which you were trained. You also become trained in Pathfinder Lore, or an expert if you were already trained. When using a skill untrained, your proficiency bonus is equal to your level instead of 0. You gain access to (item: wayfinders | wayfinder)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("0b3b0ca1-cf8c-4c1d-b8a1-8c0ae2985488"), "Member of the Pathfinder Society");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e5e7428-1920-4356-80ce-cfe5ae0f996c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
