using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiWeaponAptitude : Template
    {
        public static readonly Guid ID = Guid.Parse("9a776efc-2c08-4f46-bbfa-8268476a664d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Aptitude",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4717edeb-aba8-497a-86bc-6cf874d52227"), Type = TextBlockType.Text, Text = $"You become familiar with using your weapons both in and out of water. Whenever you critically hit using an azarketi weapon or one of the weapons listed in {ToMarkdownLink<Models.Entities.Feat>("Azarketi Weapon Familiarity", Feats.Instances.AzarketiWeaponFamiliarity.ID)}, you apply the weapon's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("39277b05-b684-42a4-8425-399fd933c0e1"), Feats.Instances.AzarketiWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3132cd-f6bc-45fe-aa0d-515ffc2b2b95"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
