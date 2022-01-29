using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StarlitEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("7e499e0d-82e1-409d-8520-8779986dc5c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Starlit Eyes",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9304ba95-d296-4299-8e46-742b70e7e4d0"), Type = TextBlockType.Text, Text = $"Starlight shines in your sight, enhancing your perception and range. When you make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} while in {ToMarkdownLink<Models.Entities.Feat>("Arcane Cascade", Feats.Instances.ArcaneCascade.ID)} stance, you lower the DC of your flat check to target a creature that's concealed or hidden from you. The DC is reduced to 3 instead of 5 against a concealed creature and to 9 instead of 11 against a hidden one. When you cast {ToMarkdownLink<Models.Entities.Spell>("shooting star", Spells.Instances.ShootingStar.ID)} and target a hidden creature, you don't have to attempt the flat check for targeting a hidden creature with a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6f3487da-475e-4846-964e-5b07bc22e47a"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("837b9d8d-d9f7-495a-b3bb-4044833cd7e7"), HybridStudies.Instances.StarlitSpan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16956df9-0ee8-4a79-81b4-5865aa13f550"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
