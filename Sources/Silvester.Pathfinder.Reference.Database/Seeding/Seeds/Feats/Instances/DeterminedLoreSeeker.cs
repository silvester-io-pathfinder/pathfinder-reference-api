using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeterminedLoreSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("d9d744ef-61d4-4504-af66-0684f54b29d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Determined Lore Seeker",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbeaee46-8cd7-4d9c-8dc5-a3969e1debeb"), Type = TextBlockType.Text, Text = "You&#39;ve mastered useful spells that let you find hidden truths others might miss, and a preferred spell comes naturally to you. When you gain this feat, choose one of the innate spells granted by the (feat: Lore Seeker) feat: (spell: comprehend language), (spell: restore senses), or (spell: see invisibility). You can cast this spell three times per day instead of once per day." };
            yield return new TextBlock { Id = Guid.Parse("762ebcfc-983c-4322-8048-707f8825fa17"), Type = TextBlockType.Text, Text = "When you cast any of the spells granted by (feat: Lore Seeker) as innate spells, they gain additional effects. When you cast (spell: comprehend language), the spell is heightened to 4th level. When you cast (spell: restore senses), the spell is heightened to half your level, rounded up. When you cast (spell: see invisibility), for the duration of the spell you can use an action, which has the (trait: concentrate) trait, to see invisible creatures normally (instead of seeing them as translucent shapes that are concealed to you) until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0d8c5692-3d19-4b94-9e73-314a0a52a440"), Feats.Instances.LoreSeeker.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c6474d-ec87-49ff-a722-c95150b22ab6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
